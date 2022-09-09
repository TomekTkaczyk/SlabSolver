using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolver.Domain
{
    public interface ISlabSolver
    {
        IList<SlabResult> SolveByLoad(int span, Loads load, Exposure exposure, FireResistance resistance);
        IList<SlabResult> SolveByEffect(float Vrd, float Mrd, float Med, float Medfreq, float Medqper, Exposure exposure, FireResistance resistance);
    }
}
