using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
