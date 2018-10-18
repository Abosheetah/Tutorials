using System;

namespace AsProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 200;
            byte? y = x as byte? ;
            Console.WriteLine(y.HasValue);
        }
    }
}
