using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQDEMO
{
    public class Employee
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Employee> GetEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            Employee obj1 = new Employee()
            {
                ID = 101,
                Name = "ALKA",
                Gender = "Female"

            };
            obj1.ID = 102;
            obj1.Name = "bhoop";
            obj1.Gender = "Male";
            emplist.Add(obj1);

            obj1.ID = 103;
            obj1.Name = "John";
            obj1.Gender = "Male";
            emplist.Add(obj1);
            return emplist;
        }

    }
}