using SlabSolver;
using SlabSolver.Domain;
using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class LoadsTest
    {
        [Fact]
        public void Addload_shoul_by_return_valid_loads() 
        {
            var loads = new Loads();
            loads.AddLoad(new Load(LoadType.Dead,1));
            loads.AddLoad(new Load(LoadType.Snow_CEN_below_1000m,2));
            loads.AddLoad(new Load(LoadType.Action_Category_B, 3));

            Assert.True(Float.NearlyEqual(7.5f, loads.ULS_STR, 0.001f));
            Assert.True(Float.NearlyEqual(6.0f, loads.ULS_STR_A, 0.001f));
            Assert.True(Float.NearlyEqual(7.3f, loads.ULS_STR_B, 0.001f));

            Assert.True(Float.NearlyEqual(5.1f, loads.SLS_CHAR, 0.001f));
            Assert.True(Float.NearlyEqual(2.9f, loads.SLS_FREQ, 0.001f));
            Assert.True(Float.NearlyEqual(2.3f, loads.SLS_QPER, 0.001f));
        }
    }
}
