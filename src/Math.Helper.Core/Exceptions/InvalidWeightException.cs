using System;

namespace Math.Helper.Core.Exceptions
{
    public class InvalidWeightException : Exception
    {
        public InvalidWeightException(string message) : base(message)
        {
        }
    }
}