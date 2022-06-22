using System;
using Xunit;
using Calculations.Models;

namespace Calculations.Tests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var name = new Names();
            var result = name.MakeFullName("Marcelo", "Santos");
            Assert.Equal("marcelo Santos", result, ignoreCase:true);
        }

        [Fact]
        public void MakeFullName_ContainsTest()
        {
            var name = new Names();
            var result = name.MakeFullName("Marcelo", "Santos");
            Assert.Contains("marcelo", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullName_RegexTest()
        {
            var name = new Names();
            var result = name.MakeFullName("Marcelo", "Santos");
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var name = new Names();
            var result = name.MakeFullName("Marcelo", "Santos");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var name = new Names();
            Assert.Null(name.NickName);
        }
    }
}
