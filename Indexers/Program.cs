using System;
using System.Collections.Generic;
using System.Linq;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenArr arr = new EvenArr(10);
            arr[0] = 2;
            arr[1] = 6;
            //Console.WriteLine(arr[1]);
            //Console.ReadLine();

            Company company  = new Company();
            Console.WriteLine(company[3].ToString());
        }
        }
    }

    class EvenArr{
        private int[] privateArray;

        public EvenArr(int size){
            privateArray = new int[size];
        }

        public int this[int index]
        {
            get { return privateArray[index] ; }
            set { if (value % 2 == 0)
            {
                privateArray[index] = value ;
            }
            else
            {
                throw new Exception("even numbers only is allowed");
            } }
        }
    }




    //another example.
    public class Customer{
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class Company{
        private List<Customer> _customers;

        public Company(){
            _customers = new List<Customer>();
            _customers.Add(new Customer(){ID = 1 , Name = "Mohamed Ahmed Maher" , Age = 33});
            _customers.Add(new Customer(){ID = 2 , Name = "Ali salama" , Age = 20});
            _customers.Add( new Customer(){ID = 3 , Name = "Omar Samy" , Age = 6});
            _customers.Add( new Customer(){ID = 4 , Name = "Kamal Rashed" , Age = 12});
            _customers.Add(new Customer(){ID = 5 , Name = "Yahya Ahmed" , Age = 58}); 
        }

        public string this[int customerID]{
            get{
                return _customers.FirstOrDefault(i=> i.ID == customerID).Name.ToString();
            }
            set{
                _customers[customerID].Name = value;
            }
        }
    }

