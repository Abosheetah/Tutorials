using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "mohamed" ;
            Console.WriteLine(name.toUpper80());
            Console.ReadLine();
        }
    }

    
    public static class MyExtensionMethods{
        public static string toUpper80(this string text){
            return text + " !";
        }
    }
}
