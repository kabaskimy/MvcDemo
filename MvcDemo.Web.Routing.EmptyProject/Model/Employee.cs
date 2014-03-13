using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Web.Routing.EmptyProject.Model
{
    public class Employee
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Gender {get;private set;}
        public DateTime BirthDate { get; private set; }
        public string Department { get; private set; }

        public Employee(string id, string name, string gender, DateTime birthdate, string department)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.BirthDate = birthdate;
            this.Department = department;
        }
    }
}