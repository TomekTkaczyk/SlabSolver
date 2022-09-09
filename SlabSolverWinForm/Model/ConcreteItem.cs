using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolverWinForm.Model
{
    public class ConcreteItem : ComboItem<Concrete>
    {
        public ConcreteItem(Concrete value) : base(value) { }
    }
}
