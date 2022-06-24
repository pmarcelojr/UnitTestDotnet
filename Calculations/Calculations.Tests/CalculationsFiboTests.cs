using System.Collections.Generic;
using Xunit;
using Calculations.Models;
using Xunit.Abstractions;
using System;
using System.IO;
using Calculations.Tests.Share;

namespace Calculations.Tests
{
    public class CalculationsFiboTests : IClassFixture<CalculationsFiboFixture>, IDisposable
    {
        private readonly CalculationsFiboFixture _calculationsFiboFixture;
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryStream _memoryStream;

        public CalculationsFiboTests(CalculationsFiboFixture calculationsFiboFixture, ITestOutputHelper testOutputHelper)
        {
            _calculationsFiboFixture = calculationsFiboFixture; // Singleton Object
            _testOutputHelper = testOutputHelper; // Informações de depuração
            _memoryStream = new MemoryStream();
            _testOutputHelper.WriteLine("Constructor");
        }

        public void Dispose()
        {
            _memoryStream.Close();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
            var calc = _calculationsFiboFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            _testOutputHelper.WriteLine("FiboDoesNotInclude4");
            var calc = _calculationsFiboFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            _testOutputHelper.WriteLine("FbioInclude13");
            var calc = _calculationsFiboFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            _testOutputHelper.WriteLine("Test Starting at {0}", DateTime.Now);

            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            _testOutputHelper.WriteLine("Creating an instance of CalculationsFibo Class");
            var calc = _calculationsFiboFixture.Calc;

            _testOutputHelper.WriteLine("Asserting...");
            Assert.Equal(expectedCollection, calc.FiboNumbers);

            _testOutputHelper.WriteLine("End");
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new CalculationsFibo();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
