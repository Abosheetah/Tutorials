using System;
using System.Collections.Generic;
using System.Linq;

namespace FunAndAction3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(){
                new Employee(){ ID = 1 , Name = "mohamed" },
                new Employee(){ ID = 2 , Name = "Ahmed" },
                new Employee(){ ID = 3 , Name = "Ali" },
                new Employee(){ ID = 4 , Name = "Salem" },
                new Employee(){ ID = 5 , Name = "Ramy" },
                
            };


            Func<Employee,string> selector = (emp) => "Name : " + emp.Name.ToString();
            IEnumerable<string> names = employees.Select(selector);

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }


        }
    }


    public class Employee{
        public int ID { get; set; }
        public string Name { get; set; }

    }

}
