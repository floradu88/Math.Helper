using System.Collections.Generic;

namespace Math.Helper.Core.Arguments
{
    using Math.Helper.Core.Interfaces;

    public class RangeArgument
    {
        public decimal this[int i] {
            get { return Values[i]; }
            set { Values[i] = value; }
        }

        public int Length
        {
            get
            {
                if (Values == null)
                    return 0;

                return Values.Count;
            }
        }

        public List<decimal> Values { get; set; }
    }
}