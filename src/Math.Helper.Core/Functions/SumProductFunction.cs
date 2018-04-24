using System;
using System.Collections.Generic;
using System.Linq;
using Math.Helper.Core.Arguments;

namespace Math.Helper.Core.Functions
{
    using Core.Interfaces;
    using Math.Helper.Core.Exceptions;

    public partial class SumProductFunction : IFunction
    {
        public decimal Calculate(IEnumerable<RangeArgument> parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException("Invalid Parameters Supplied");

            if (parameters.Count() != 2)
                throw new InvalidOperationException("Invalid number of arguments supplied");

            var values = parameters.First();
            var weights = parameters.Last();

            if (values.Length != weights.Length)
                throw new InvalidParameterException("Lengths of the parameters are different");

            var divider = weights.Values.Sum();

            if (divider == 0)
                throw new InvalidWeightException("Sum of weights needs to be greater than 0");

            var result = 0.0m;

            for (int i = 0; i < values.Values.Count; i++)
                result += values.Values[i] * weights.Values[i];

            return result / divider;
        }
    }
}