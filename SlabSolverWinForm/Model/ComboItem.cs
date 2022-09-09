using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlabSolverWinForm.Model
{
    public class ComboItem<T> where T : Enum
    {
        public ComboItem(T value)
        {
             Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
