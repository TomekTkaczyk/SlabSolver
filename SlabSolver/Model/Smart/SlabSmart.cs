using SlabSolver.Domain;
using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolver.Model.Smart
{
    public class SlabSmart : Slab
    {
        public List<LoadCapacity> LoadCapacity { get; set; }

        public SlabSmart(
            string signature,
            int thickness,
            Concrete concrete,
            FireResistance fireResistance,
            float mcr,
            float mcr_topedge,
            float mcrw02,
            float mdec,
            float mrd,
            float mrd_topedge,
            float vrd,
            float q

            ) : base(signature, thickness, concrete, fireResistance, mcr, mcr_topedge, mcrw02, mdec, mrd, mrd_topedge, vrd, q)
        {
            LoadCapacity = new List<LoadCapacity>();
        }
    }
}
