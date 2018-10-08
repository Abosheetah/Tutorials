using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null ;
            if (x.HasValue)
            {
                Console.WriteLine($"the value is : {x}");                
            }
            else
            {
                Console.WriteLine("not exist any value.");
            }

            int? r = 50;

            int rr = r ?? 1;

            Console.WriteLine(rr);

        }
    }
}
