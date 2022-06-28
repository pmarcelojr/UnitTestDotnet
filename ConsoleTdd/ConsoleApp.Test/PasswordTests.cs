using System;
using Xunit;

namespace ConsoleApp.Test
{
    public class PasswordTests
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(8)+"A";
            var validationResult = target.Validate(password);

            Assert.True(validationResult);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(6)+"A";
            var validationResult = target.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenOneUpperCase_ReturnsTrue()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(8)+"A"; // one UpperCase
            var validationResult = target.Validate(password);

            Assert.True(validationResult);
        }

        [Fact]
        public void Validate_GivenNoUpperCase_ReturnsFalse()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(8); // all no upper case
            var validationResult = target.Validate(password);

            Assert.False(validationResult);
        }

        public string MakeString(int length)
        {
            string result = "";
            for (int i = 1; i < length; i++)
            {
                result += "a";
            }
            return result;
        }
    }
}
