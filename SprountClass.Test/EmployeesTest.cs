using Moq;
using SproutClass;
using System;
using System.Collections.Generic;
using Xunit;

namespace SprountClass.Test
{
    public class EmployeesTest
    {
        [Fact]
        public void GetEmployeeData_ReturnsSalaries()
        {
            var currentDataObject = new Mock<IEmployeeService>();
            currentDataObject.Setup(x => x.GetEmployeesData()).Returns(new List<Employee>() { new Employee { UniqueId = 1, Salary = 100 } });
            var salaryData = currentDataObject.Object.GetEmployeesData();

            Assert.Contains(salaryData, x => x.Salary > 0);
        }
    }
}
