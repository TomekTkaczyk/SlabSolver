using SlabSolver.Domain;
using SlabSolver.Enums;
using SlabSolver.Model.Smart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class SmartTests
    {
        [Fact]
        public void Solver_should_by_return_list_smarts()
        {
            var solver = new SolverSmart(new ServiceSmart());
            var load = new Loads();
            load.AddLoad(new Load(LoadType.Dead, 4));
            load.AddLoad(new Load(LoadType.Action_Category_E, 3));

            var slabs = solver.SolveByLoad(605, load, Exposure.XC1, FireResistance.REI60).Select(x => x.Slab as SlabSmart).ToList();

            Assert.Equal("SMART 15/60 2ø12.5+2ø9.3+2ø6.85,kanały 60x90,REI60", slabs[0].Signature);
        }
    }
}
