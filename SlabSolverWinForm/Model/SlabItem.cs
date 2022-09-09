using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolverWinForm.Model
{
    public class SlabItem : ComboItem<SlabType>
    {
        public SlabItem(SlabType value) : base(value) { }

        public override string ToString()
        {
            return "Płyta stropowa " + Value.ToString();
        }
    }
}
