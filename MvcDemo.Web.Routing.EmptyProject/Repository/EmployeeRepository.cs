using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcDemo.Web.Routing.EmptyProject.Model;

namespace MvcDemo.Web.Routing.EmptyProject.Repository
{
    public class EmployeeRepository
    {
        private static IList<Employee> employees;

        static EmployeeRepository()
        {
            employees = new List<Employee>();
            employees.Add(new Employee(Guid.NewGuid().ToString(), "Ballack", "Male", new DateTime(1976, 9, 26), "MF"));
            employees.Add(new Employee(Guid.NewGuid().ToString(), "Muller", "Male", new DateTime(1989, 2, 3), "Striker"));
            employees.Add(new Employee(Guid.NewGuid().ToString(), "Kahn", "Male", new DateTime(1968, 10, 3), "GK"));
            employees.Add(new Employee(Guid.NewGuid().ToString(), "Prince", "Female", new DateTime(1979, 5, 4), "Striker"));
        }

        public IEnumerable<Employee> GetEmployees(string id = "")
        {
            return employees.Where(e => e.Id == id || string.IsNullOrEmpty(id) || id == "*");
        }
    }
}