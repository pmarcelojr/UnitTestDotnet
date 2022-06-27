using System;
using System.Collections.Generic;
using Xunit;

namespace SproutMethod.Tests
{
    public class LegacyClassTest
    {
        [Fact]
        public void GetValidItems_GivenTwoDictionaries_ReturnsUncommonItems()
        {
            var legacy = new LegacyClass();
            var dic1 = new Dictionary<int, int>() { { 1, 0 }, { 2, 0 }, { 3, 0 }};
            var dic2 = new Dictionary<int, int>() { { 7, 0 }, { 8, 0 }, { 9, 0 }, { 1, 800 } };

            var validItem = legacy.GetValidItems(dic1, dic2);
            var expectedResult = new Dictionary<int, int>() { {2, 0 }, { 3, 0 } };

            Assert.Equal(validItem, expectedResult);
        }
    }
}
