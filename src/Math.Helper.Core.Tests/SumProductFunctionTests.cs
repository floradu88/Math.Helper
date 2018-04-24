using System;
using System.Collections.Generic;
using Math.Helper.Core.Exceptions;
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
            Assert.Throws<ArgumentNullException>(() => new SumProductFunction().Calculate(null));
        }

        [Fact]
        public void should_calculate_sumproduct_throws_exception_when_parameters_is_empty()
        {
            Assert.Throws<InvalidOperationException>(() => new SumProductFunction().Calculate(new List<RangeArgument>()));
        }

        [Fact]
        public void should_calculate_sumproduct_throws_exception_when_parameters_lists_arent_matching()
        {
            var rangeArgumentA = new RangeArgument()
            {
                Values = new List<decimal>()
                {
                    1
                }
            };

            var rangeArgumentB = new RangeArgument()
            {
                Values = new List<decimal>()
            };

            List<RangeArgument> parameters = new List<RangeArgument>()
            {
                rangeArgumentA,
                rangeArgumentB
            };

            Assert.Throws<InvalidParameterException>(() => new SumProductFunction().Calculate(parameters));
        }

        [Fact]
        public void should_calculate_sumproduct_as_expected()
        {
            var rangeArgumentA = new RangeArgument()
            {
                Values = new List<decimal>()
                {
                    1,
                    2,
                    3
                }
            };

            var rangeArgumentB = new RangeArgument()
            {
                Values = new List<decimal>()
                {
                    0.5m,
                    2,
                    3
                }
            };

            List<RangeArgument> parameters = new List<RangeArgument>()
            {
                rangeArgumentA,
                rangeArgumentB
            };

            var result = new SumProductFunction().Calculate(parameters);
            var expectedResult = 2.4545454545454545454545454545m;

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void should_calculate_sumproduct_as_expected_when_values_are_invalid()
        {
            var rangeArgumentA = new RangeArgument()
            {
                Values = new List<decimal>()
                {
                    1,
                    2,
                    3
                }
            };

            var rangeArgumentB = new RangeArgument()
            {
                Values = new List<decimal>()
                {
                    1,
                    -1,
                    0
                }
            };

            List<RangeArgument> parameters = new List<RangeArgument>()
            {
                rangeArgumentA,
                rangeArgumentB
            };

            Assert.Throws<InvalidWeightException>(() => new SumProductFunction().Calculate(parameters));
        }
    }
}
