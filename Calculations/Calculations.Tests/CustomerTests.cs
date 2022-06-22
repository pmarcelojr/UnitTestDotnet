using Calculations.Models;
using System;
using Xunit;

namespace Calculations.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        // Asserting a range of values para validar range de idade ou algo semelhante
        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);
        }

        // Asserting Exceptions para validar Excessões
        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("Teste Exception", exceptionDetails.Message);
        }

        // Asserting Object Type
        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            // criamos uma nova instancia a partir do metodo
            var customer = CustomerFactory.CreateCustomerInstance(102); // 100 loyal 99 customer
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);// Valida se customer é do tipo LoyalCustomer
            Assert.Equal(10, loyalCustomer.Discount); // Valida discount
        }
    }
}
