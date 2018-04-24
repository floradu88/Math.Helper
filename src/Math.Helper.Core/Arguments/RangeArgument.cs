using System.Collections.Generic;

namespace Math.Helper.Core.Arguments
{
    using Math.Helper.Core.Interfaces;

    public class RangeArgument<TType> : IArgument<TType>
    {
        public int Length
        {
            get
            {
                if (Values == null)
                    return 0;

                return Values.Count;
            }
        }

        public List<TType> Values { get; set; }
    }
}