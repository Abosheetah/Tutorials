using System;

namespace isProj
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new  B();
            bool x = b is A ;
            Console.WriteLine(x);
        }
    }


    class A{
        public int ID { get; set; }
        public string Name { get; set; }        
    }


    class B : A {
        public float Speed { get; set; }
    }
}
