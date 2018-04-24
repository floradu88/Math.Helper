using System.Collections.Generic;

namespace Math.Helper.Core.Interfaces
{
    public interface IFunction
    {
        TParamType Calculate<TParamType, TType>(IEnumerable<TParamType> parameters) where TParamType : IArgument<TType>;
    }
}
