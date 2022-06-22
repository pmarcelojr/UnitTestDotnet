using System.Collections.Generic;
using Xunit;
using Calculations.Models;

namespace Calculations.Tests
{
    public class CalculationsFiboTests : IClassFixture<CalculationsFiboFixture>
    {
        private readonly CalculationsFiboFixture _calculationsFiboFixture;

        public CalculationsFiboTests(CalculationsFiboFixture calculationsFiboFixture)
        {
            _calculationsFiboFixture = calculationsFiboFixture; // Singleton Object
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculationsFiboFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var calc = _calculationsFiboFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculationsFiboFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculationsFiboFixture.Calc;
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }
    }
}
