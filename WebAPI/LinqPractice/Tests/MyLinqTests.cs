using FluentAssertions;
using NUnit.Framework;
using WebAPI.LinqPractice.Models;
using WebAPI.LinqPractice.Utilities;

namespace WebAPI.LinqPractice.Tests;

[TestFixture]
public class MyLinqTests
{
    [Test]
    public void get_employee_age_greater_than_25()
    {
        var employees = RepositoryFactory.GetEmployees();
        // implement GetEmployeesAgeGreaterThan25
        var actual = MyLinq.GetEmployeesAgeGreaterThan25(employees);

        var expected = new List<Employee>()
        {
            new Employee { Name = "Joe", Role = RoleType.Engineer, MonthSalary = 100, Age = 44, WorkingYear = 2.6 },
            new Employee { Name = "Tom", Role = RoleType.Engineer, MonthSalary = 140, Age = 33, WorkingYear = 2.6 },
            new Employee { Name = "Kevin", Role = RoleType.Manager, MonthSalary = 380, Age = 55, WorkingYear = 2.6 },
            new Employee { Name = "Bas", Role = RoleType.Engineer, MonthSalary = 280, Age = 36, WorkingYear = 2.6 },
            new Employee { Name = "Mary", Role = RoleType.OP, MonthSalary = 180, Age = 26, WorkingYear = 2.6 },
            new Employee { Name = "Joey", Role = RoleType.Engineer, MonthSalary = 250, Age = 40, WorkingYear = 2.6 },
        };

        expected.Should().BeEquivalentTo(actual);
    }

    [Test]
    public void get_fruit_price_bigger_than_150()
    {
        var fruits = RepositoryFactory.GetFruits();
        // implement GetEmployeesMonthSalaryBiggerThan150
        var actual = MyLinq.GetFruitPriceBiggerThan150(fruits);
        
        var expected = new List<Fruit>()
        {
            new Fruit {Name = "Cherry", Price = 200},
            new Fruit {Name = "Durian", Price = 300},
            new Fruit {Name = "Honeydew", Price = 250},
        };

        expected.Should().BeEquivalentTo(actual);
    }
}