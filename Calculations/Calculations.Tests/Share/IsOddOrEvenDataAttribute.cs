using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace Calculations.Tests.Share
{
    public class IsOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new Object[] { 1, true };
            yield return new object[] { 2, false };
        }
    }
}
