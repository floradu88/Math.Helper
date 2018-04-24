using System;
using System.Collections.Generic;
using Math.Helper.Core.Arguments;

namespace Math.Helper.Core.Interfaces
{
    public interface IFunction
    {
        decimal Calculate(IEnumerable<RangeArgument> parameters);
    }
}
