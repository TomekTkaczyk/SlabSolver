using SlabSolver.Domain;
using SlabSolver.Enums;
using SlabSolver.Model.Smart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolver
{
    public class SolverFactory
    {
        public ISlabSolver CreateSolver(SlabType type)
        {
            switch (type)
            {
                case SlabType.SMART:
                    {
                        return new SolverSmart(new ServiceSmart());
                    }
                default: throw new ArgumentException();
            }
        }

        public List<string> SlabsList()
        {
            return Enum.GetNames(typeof( SlabType )).ToList();
        }
    }
}
