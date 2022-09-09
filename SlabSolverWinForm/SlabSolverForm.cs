using SlabSolver;
using SlabSolver.Domain;
using SlabSolver.Enums;
using SlabSolverWinForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace SlabSolverWinForm
{
    public partial class SlabSolverForm : Form
    {
        private readonly Loads Loads;

        private readonly SolverFactory SolverFactory;

        private ISlabSolver Solver;

        private IList<SlabResult> Slabs;

        public SlabSolverForm()
        {
            SolverFactory = new SolverFactory();
            Loads = new Loads();
            Slabs = new List<SlabResult>();
            InitializeComponent();

            var enumValues = Enum.GetValues((typeof(SlabType)));
            foreach (SlabType item in (SlabType[])enumValues)
            {
                cmbSlabsTypes.Items.Add(new SlabItem(item));
            }
            cmbSlabsTypes.SelectedItem = cmbSlabsTypes.Items[0];

            enumValues = Enum.GetValues((typeof(FireResistance)));
            foreach (FireResistance item in (FireResistance[])enumValues)
            {
                cmbFireResistant.Items.Add(new FireResistantItem(item));
            }
            cmbFireResistant.SelectedItem = cmbFireResistant.Items[0];

            enumValues = Enum.GetValues((typeof(Exposure)));
            foreach (Exposure item in (Exposure[])enumValues)
            {
                cmbExposure.Items.Add(new ExposureItem(item));
            }
            cmbExposure.SelectedItem = cmbExposure.Items[0];

            enumValues = Enum.GetValues((typeof(LoadType)));
            foreach (LoadType item in (LoadType[])enumValues)
            {
                cmbLoadType.Items.Add(new LoadTypeItem(item));
            }
            cmbLoadType.SelectedItem = cmbLoadType.Items[0];

            Solver = SolverFactory.CreateSolver(((SlabItem)cmbSlabsTypes.SelectedItem).Value);
        }

        private void Solver_Load(object sender, EventArgs e)
        {
            nudSpan.Value = 600;
            SlabsResolve(tabControl1.SelectedIndex);

#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            cmbSlabsTypes.SelectedValueChanged += cmbSlabsTypes_SelectedValueChanged;
            cmbExposure.SelectedValueChanged += SelectedValueChanged;
            cmbFireResistant.SelectedValueChanged += SelectedValueChanged;
            nudSpan.ValueChanged += SelectedValueChanged;
            dgvLoads.RowsRemoved += dgvLoads_RowsRemoved;
            tbxVrd.TextChanged += SelectedValueChanged;
            tbxMrd.TextChanged += SelectedValueChanged;
            tbxMed.TextChanged += SelectedValueChanged;
            tbxMefreq.TextChanged += SelectedValueChanged;
            tbxMeqper.TextChanged += SelectedValueChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        private void SlabsResolve(int tabIndex)
        {
            var fireResistant = (FireResistantItem)cmbFireResistant.SelectedItem;
            var exposure = (ExposureItem)cmbExposure.SelectedItem;
            switch (tabIndex)
            {
                case 0:
                    {
                        var span = Convert.ToInt32(Math.Round(nudSpan.Value, 0));
                        Slabs = Solver.SolveByLoad(span, Loads, exposure.Value, fireResistant.Value);
                        break;
                    }
                case 1:
                    {
                        var Vrd = 0f;
                        float.TryParse(tbxVrd.Text, out Vrd);
                        var Mrd = 0f;
                        float.TryParse(tbxMrd.Text, out Mrd);
                        var Med = 0f;
                        float.TryParse(tbxMed.Text, out Med);
                        var Medfreq = 0f;
                        float.TryParse(tbxMefreq.Text, out Medfreq);
                        var Medqper = 0f;
                        float.TryParse(tbxMeqper.Text, out Medqper);

                        Slabs = Solver.SolveByEffect(Vrd, Mrd, Med, Medfreq, Medqper, exposure.Value, fireResistant.Value);
                        break;
                    }
            }
            SlabDataGriReload();
        }

        private void SlabDataGriReload()
        {
            dgvSlabs.Rows.Clear();
            foreach (var item in Slabs)
            {
                dgvSlabs.Rows.Add(item.Guid, item.Slab.Signature, ((int)(item.Condition * 100)).ToString() + "%");
            }
        }

        private void tbxLoadValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar != 8)
            {

                if (!float.TryParse(((TextBox)sender).Text + e.KeyChar, out float number))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddLoad_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbxLoadValue.Text, out float number))
            {
                if (number > 0)
                {
                    Loads.AddLoad(new Load(((LoadTypeItem)cmbLoadType.SelectedItem).Value, number));
                }
            }
            LoadsDataGridReload();
        }

        private void dgvLoads_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Loads.DelLoad(Loads.LoadsList[e.RowIndex].Guid);
            LoadsDataGridReload();
        }

        private void LoadsDataGridReload()
        {
            dgvLoads.RowsRemoved -= dgvLoads_RowsRemoved;
            dgvLoads.Rows.Clear();
            foreach (var loadItem in Loads.LoadsList)
            {
                dgvLoads.Rows.Add(loadItem.Guid, SlabSolver.Domain.Load.GetLoadName(loadItem.Type), loadItem.Value);
            }
            dgvLoads.RowsRemoved += dgvLoads_RowsRemoved;
            tbxULS_EQU.Text = Round(Loads.ULS_EQU);
            tbxULS_STR.Text = Round(Loads.ULS_STR);
            tbxULS_STRA.Text = Round(Loads.ULS_STR_A);
            tbxULS_STRB.Text = Round(Loads.ULS_STR_B);
            tbxULS_GEO.Text = Round(Loads.ULS_GEO);
            tbxSLS_CHAR.Text = Round(Loads.SLS_CHAR);
            tbxSLS_FREQ.Text = Round(Loads.SLS_FREQ);
            tbxSLS_QPER.Text = Round(Loads.SLS_QPER);

            SlabsResolve(tabControl1.SelectedIndex);
        }

        private void cmbSlabsTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            var slabType = (SlabItem)cmbSlabsTypes.SelectedItem;
            Solver = SolverFactory.CreateSolver(slabType.Value);
            SelectedValueChanged(sender, e);
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            SlabsResolve(tabControl1.SelectedIndex);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = (TabControl)sender;

            SlabsResolve(tabControl.SelectedIndex);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            var printDialog = new PrintDialog()
            {
                Document = reportDocument
            };

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                reportDocument.Print();
            }

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
            }
        }

        private void reportDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        SlabReportLoad(e.Graphics);
                        break;
                    }
                case 1:
                    {
                        SlabReportEffect(e.Graphics);
                        break;
                    }
            }
        }

        private string Round(float value)
        {
            return (((float)((int)(value * 100)) / 100)).ToString();
        }

        private void Criteria(Graphics g, int y)
        {
            var fontRegular = new Font("Arial", 8, FontStyle.Regular);

            y += 25;
            g.DrawString("Kryterium", fontRegular, Brushes.Black, new Point(30, y));
            g.DrawString("Wytężenie", fontRegular, Brushes.Black, new Point(150, y));

            foreach (SlabResult slab in Slabs)
            {
                y += 15;
                g.DrawString(slab.Slab.ToString(), fontRegular, Brushes.Black, new Point(20, y));
                foreach (var condition in slab.Conditions)
                {
                    y += 15;
                    g.DrawString(condition.Item1, fontRegular, Brushes.Black, new Point(30, y));
                    g.DrawString(((int)(condition.Item2 * 100)).ToString() + "%", fontRegular, Brushes.Black, new Point(150, y));
                }
            }
        }

        private void SlabReportEffect(Graphics g)
        {
            var pen = new Pen(Color.Black);
            var fontBold = new Font("Arial", 8, FontStyle.Bold);

            g.DrawString("Wynik doboru stropu: SMART", fontBold, Brushes.Black, new Point(20, 10));
            g.DrawLine(pen, new Point(10, 25), new Point(800, 25));
            var y = 35;
            g.DrawString("Siła poprzeczna obliczeniowa=" + tbxVrd.Text + " kN", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("Moment zginający obliczeniowy=" + tbxMrd.Text + " kN", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("Moment zginający charakterystyczny=" + tbxMed.Text + " kN", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("Moment zginający charakterystyczny dla komb. częstej=" + tbxMefreq.Text + " kN", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("Moment zginający charakterystyczny dla komb. quasi stałej=" + tbxMeqper.Text + " kN", fontBold, Brushes.Black, new Point(20, y));
            y += 15;

            Criteria(g, y);
        }

        private void SlabReportLoad(Graphics g)
        {
            var pen = new Pen(Color.Black);
            var fontBold = new Font("Arial", 8, FontStyle.Bold);

            g.DrawString("Wynik doboru stropu: SMART", fontBold, Brushes.Black, new Point(20, 10));
            g.DrawLine(pen, new Point(10, 25), new Point(800, 25));
            var y = 35;
            g.DrawString("ULS EQU="+ Round(Loads.ULS_EQU)+" kPa", fontBold, Brushes.Black, new Point(20, y));
            g.DrawString("Klasa środowiska " + cmbExposure.SelectedItem.ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(200, y));
            y += 15;
            g.DrawString("ULS STR=" + Round(Loads.ULS_STR)+" kPa", fontBold, Brushes.Black, new Point(20, y));
            g.DrawString("Rozpiętość stropu L=" + nudSpan.Value + "cm", fontBold, Brushes.Black, new Point(200, y));
            y += 15;
            g.DrawString("ULS STR(a)=" + Round(Loads.ULS_STR_A) + " kPa", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("ULS STR(b)=" + Round(Loads.ULS_STR_B) + " kPa", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("ULS GEO=" + Round(Loads.ULS_GEO) + " kPa", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("SLS CHAR=" + Round(Loads.SLS_CHAR) + " kPa", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("SLS FREQ=" + Round(Loads.SLS_FREQ) + " kPa", fontBold, Brushes.Black, new Point(20, y));
            y += 15;
            g.DrawString("SLS QPER=" + Round(Loads.SLS_QPER) + " kPa", fontBold, Brushes.Black, new Point(20, y));
            y += 25;
            
            Criteria(g, y);
        }

        private void SlabSolverForm_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 350;
        }
    }
}
