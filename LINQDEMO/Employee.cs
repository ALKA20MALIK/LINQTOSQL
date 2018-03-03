using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQDEMO
{
    public static class stringConvert{
        public static string DoFirstLetterToupperCase(this string obj)
        {
            char[] array = obj.ToCharArray();
            if (obj != null)
            {
                
                array[0] = char.ToUpper(array[0]);
                //obj = array.ToString();
            }
            return new string(array);
        }
}
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
                Name = "alka",
                Gender = "Female"

            };
            emplist.Add(obj1);
            Employee obj2 = new Employee()
            {
                ID = 102,
                Name="bhoop".DoFirstLetterToupperCase(),
                Gender = "Male"

            };
            emplist.Add(obj2);

            Employee obj3 = new Employee()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            emplist.Add(obj3);
            
            return emplist;
        }
       
    }
}