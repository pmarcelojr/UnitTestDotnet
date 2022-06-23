using Calculations.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class CustomerDetailsTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = new Customer();
            Assert.Equal("Marcelo Santos", customer.GetFullName("Marcelo", "Santos"));
        }
    }
}
