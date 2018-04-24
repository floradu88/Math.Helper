using System;
using System.Collections.Generic;

using Xunit;


namespace Math.Helper.Core.Tests
{
    using Math.Helper.Core.Arguments;
    using Math.Helper.Core.Functions;

    public class SumProductFunctionTests
    {
        [Fact]
        public void should_calculate_sumproduct_throws_exception_when_parameters_is_null()
        {
            Assert.Throws<ArgumentNullException>(() => new SumProductFunction().Calculate<RangeArgument<double>, double>(null));
        }

        [Fact]
        public void should_calculate_sumproduct_throws_exception_when_parameters_is_empty()
        {
            Assert.Throws<InvalidOperationException>(() => new SumProductFunction().Calculate<RangeArgument<double>, double>(new List<RangeArgument<double>>()));
        }

        [Fact]
        public void should_calculate_sumproduct_throws_exception_when_parameters_lists_arent_matching()
        {
            var rangeArgumentA = new RangeArgument<double>()
            {
                Values = new List<double>()
                {
                    1
                }
            };

            var rangeArgumentB = new RangeArgument<double>()
            {
                Values = new List<double>()
            };

            List<RangeArgument<double>> parameters = new List<RangeArgument<double>>()
            {
                rangeArgumentA,
                rangeArgumentB
            };

            Assert.Throws<Exception>(() => new SumProductFunction().Calculate<RangeArgument<double>, double>(parameters));
        }
    }
}
