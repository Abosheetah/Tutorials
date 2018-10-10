using System;
using System.Threading.Tasks;
namespace FunAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Action<int>[] actions = new Action<int>[3];
            actions[0] = new Action<int>((x) => {Console.WriteLine("Action {0}" , x);});
            actions[1] = new Action<int>((x) => {Console.WriteLine("Action {0}" , x);});
            actions[2] = new Action<int>((x) => {Console.WriteLine("Action {0}" , x);});

            ConvertToParallel(actions);
            Console.ReadLine();
        }

        static void ConvertToParallel(Action<int>[] actions){
            foreach (var item in actions)
            {
                Task.Run(() => {item(1);});
            }
        }

        static void PrintHello(){
            Console.WriteLine("Hello ");
        }
        
        static void PrintWellcom(){
            Console.WriteLine("Wellcom ");
        }
        
        static void PrintHi(){
            Console.WriteLine("Hi ");
        }
    }
}
