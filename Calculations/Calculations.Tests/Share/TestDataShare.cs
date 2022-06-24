using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Calculations.Tests.Share
{
    public static class TestDataShare
    {
        public static IEnumerable<Object[]> IsOddOrEvenData
        {
            get
            {
                yield return new Object[] { 1, true };
                yield return new Object[] { 2, false };
            }
        }

        public static IEnumerable<Object[]> IsOddOrEvenExternalData
        {
            get
            {
                var allLines = File.ReadAllLines("IsOddOrEvenTestData.txt.");
                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(",");
                    return new Object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
                });
            }
        }
    }
}
