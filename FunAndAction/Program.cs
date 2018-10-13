using System;
using System.Threading.Tasks;
namespace FunAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Action<int>[] actions = new Action<int>[4];
            actions[0] = new Action<int>((x) => PrintHello(x));
            actions[1] = new Action<int>((x) => PrintHi(x));
            actions[2] =  new Action<int>((x) => PrintWellcom(x));
            actions[3] = new Action<int>((x) => PrintMohamed(x));


            ConvertToParallel(actions);
            Console.ReadLine();
        }

        static void ConvertToParallel(Action<int>[] actions){
            foreach (var item in actions)
            {
                Task.Run(() => {item(new Random().Next(5,10));});
            }
        }

        static void PrintHello(int x){
            Console.WriteLine("Hello {0}" , x);
        }
        
        static void PrintWellcom(int x){
            Console.WriteLine("Wellcom {0}" , x);
        }
        
        static void PrintHi(int x ){
            Console.WriteLine("Hi {0}" , x);
        }

        static void PrintMohamed(int x){
            Console.WriteLine("Mohamed  {0}" , x);
        }
    }
}
