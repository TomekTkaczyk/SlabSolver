using SlabSolver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolver.Domain
{
    public interface ISlabService
    {
        IList<Slab> Slabs { get; }

        Slab GetSlab(string signature);
    }
}
