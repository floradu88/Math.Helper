using System;
using System.Collections.Generic;
using System.Linq;

namespace Math.Helper.Core.Functions
{
    using Core.Interfaces;

    public partial class SumProductFunction : IFunction
    {
        public TParamType Calculate<TParamType, TType>(IEnumerable<TParamType> parameters) where TParamType : IArgument<TType>
        {
            if (parameters == null)
                throw  new ArgumentNullException("Invalid Parameters Supplied");

            if (parameters.Count() != 2)
                throw new InvalidOperationException("Invalid number of arguments supplied");

            var values = parameters.First();
            var weights = parameters.Last();

            if (values.Length != weights.Length)
                throw new Exception("Lengths of the parameters are different");

            return default(TParamType);
        }
    }
}