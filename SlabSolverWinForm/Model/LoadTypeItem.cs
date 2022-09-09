using SlabSolver.Domain;
using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolverWinForm.Model
{
    public class LoadTypeItem : ComboItem<LoadType>
    {
        public LoadTypeItem(LoadType value) : base(value) { }

        public override string ToString()
        {
            return Load.GetLoadName(Value);
        }
    }
}
