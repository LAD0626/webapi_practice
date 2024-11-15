using WebAPI.LinqPractice.Models;

namespace WebAPI.LinqPractice.Utilities;

internal class RepositoryFactory
{
    public static IEnumerable<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee {Name = "Joe", Role = RoleType.Engineer, MonthSalary = 100, Age = 44, WorkingYear = 2.6},
            new Employee {Name = "Tom", Role = RoleType.Engineer, MonthSalary = 140, Age = 33, WorkingYear = 2.6},
            new Employee {Name = "Kevin", Role = RoleType.Manager, MonthSalary = 380, Age = 55, WorkingYear = 2.6},
            new Employee {Name = "Andy", Role = RoleType.OP, MonthSalary = 80, Age = 22, WorkingYear = 2.6},
            new Employee {Name = "Bas", Role = RoleType.Engineer, MonthSalary = 280, Age = 36, WorkingYear = 2.6},
            new Employee {Name = "Mary", Role = RoleType.OP, MonthSalary = 180, Age = 26, WorkingYear = 2.6},
            new Employee {Name = "Frank", Role = RoleType.Engineer, MonthSalary = 120, Age = 16, WorkingYear = 2.6},
            new Employee {Name = "Joey", Role = RoleType.Engineer, MonthSalary = 250, Age = 40, WorkingYear = 2.6},
        };
    }

    public static IEnumerable<Fruit> GetFruits()
    {
        return new List<Fruit>
        {
            new Fruit {Name = "Apple", Price = 100, Quantity = 10, Quality = Quality.Normal},
            new Fruit {Name = "Banana", Price = 50, Quantity = 100, Quality = Quality.Good},
            new Fruit {Name = "Cherry", Price = 200, Quantity = 25, Quality = Quality.Normal},
            new Fruit {Name = "Durian", Price = 300, Quantity = 30, Quality = Quality.Bad},
            new Fruit {Name = "Elderberry", Price = 150, Quantity = 50, Quality = Quality.Normal},
            new Fruit {Name = "Fig", Price = 80, Quantity = 40, Quality = Quality.Normal},
            new Fruit {Name = "Grape", Price = 120, Quantity = 160, Quality = Quality.Good},
            new Fruit {Name = "Honeydew", Price = 250, Quantity = 90, Quality = Quality.Normal},
        };
    }
}