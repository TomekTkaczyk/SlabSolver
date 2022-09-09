using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolver.Domain
{
    public class SlabResult
    {
        public Guid Guid { get; private set; }
        public Slab Slab { get; private set; }
        public List<Tuple<string,float>> Conditions { get; private set; }

        public float Condition { 
            get {
                return Conditions.Max(x => x.Item2);
            } 
        }

        public SlabResult(Slab slab, List<Tuple<string, float>> conditions)
        {
            Guid = new Guid();
            Slab = slab;
            Conditions = conditions;
        }
    }
}
