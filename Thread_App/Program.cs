using System;
using System.Threading;

namespace Thread_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Program.SThread);
               
            //this line is create a new instance from Thread class.
            Thread th = new Thread(ts);

            th.Start();
            Thread.Sleep(5000);
            Program.ShowMessage();

            Console.ReadLine();
            
        }



        public static void SThread(){
            Console.WriteLine("Hello Mohamed");
           
        }

        public static void ShowMessage(){
            Console.WriteLine("Hello World");
        }
    }
}
