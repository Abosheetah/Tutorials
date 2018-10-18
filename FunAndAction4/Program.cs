using System;

namespace FunAndAction4
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int,string> func = (x,y) => "Result : " + (x + y) ;
            Console.WriteLine(func(5,6));
        }


        
    }
}
