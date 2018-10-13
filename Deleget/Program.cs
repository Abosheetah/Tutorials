using System;

namespace deleget
{
public  delegate void delSay(string text);
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() {ID = 1 , Name = "Salme" , Salary = 6500};
            Employee emp2 = new Employee() {ID = 2 , Name = "mohamed" , Salary = 2300};
            Employee emp3 = new Employee() {ID = 3 , Name = "ali" , Salary = 9120};
            Employee emp4 = new Employee() {ID = 4 , Name = "saleh" , Salary = 4200};
            Employee emp5 = new Employee() {ID = 5 , Name = "rashaad" , Salary = 7300};

            Employee[] emploees = new Employee[5];
            emploees[0] = emp1;
            emploees[1] = emp2;
            emploees[2] = emp3;
            emploees[3] = emp4;
            emploees[4] = emp5;

        


           //Employee.AbleToBorrow(emploees,x => x.Salary >= 5000);

           Customer[] customers = new Customer[]{
                new Customer() {ID = 1, Name = "Mohamed" , Address = "21 Mekkawe Street" , debtAmount = 4520},
                new Customer() {ID = 2 , Name ="Ahmed" , Address = "ElMonefia city" ,debtAmount = 2450 },
                new Customer() {ID = 3 , Name ="Samy" , Address = "ElArish city" ,debtAmount = 2650 },
                new Customer() {ID = 4 , Name ="Kamal" , Address = "23Jul Street" ,debtAmount = 8425 }};
            Customer.InDebtList(customers,x=> x.debtAmount>2500);
        }

       

        public static void SayHelloAnything(string strAnything){
            Console.WriteLine($"Hello {strAnything}");
        }
    }

public delegate bool IsAbleToBorrow(Employee emploee);
    public class Employee{
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public static void AbleToBorrow(Employee[] employees,IsAbleToBorrow ableToBorrow){
            foreach (Employee employee in employees)
            {
                if (ableToBorrow(employee))
                {
                    Console.WriteLine(employee.Name.ToString());
                }
            }
        }
    }
}
