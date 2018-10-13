using System;

namespace deleget{
    public class Customer{
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal debtAmount {get;set;} 

        public static void InDebtList(Customer[] customers,InList inList){
            foreach (Customer customer in customers)
            {
                if (inList(customer))
                {
                    Console.WriteLine(customer.Name.ToString());
                }
            }
        }
           
    }
public delegate bool InList(Customer cus);
   
   public struct Supplier{
       private int _id;
       private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Supplier(int id,string name){
            _id =id;
            _name = name;
        }

        public void PrintDetails(){
            Console.WriteLine($"ID is : {_id} , Name is : {_name}");
        }
    }


    public class SupExc{
        Supplier sup = new Supplier(){  Id = 5 , Name = "Ahmed"};
        Supplier sup2 = new Supplier(2,"Samy");
        
        
    }
}