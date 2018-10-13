using System;
using System.Threading.Tasks;

namespace FunAndAction2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,string>[] functions = new Func<string, string>();
            functions[0] = new Func<string, string>((x) => SayHello(x));
            functions[1] = new Func<string, string>((x) => SayHi(x));
            functions[2] = new Func<string, string>((x) => SayWelcom(x));
            
            ExecToParallel(functions);
        }


        public ExecToParallel(Func<string,string>[] functions){
            foreach (var item in functions)
            {
                Task.Run((x) => item("Mohamed"));
            }
        }

        public string SayHello(string text){
            return $"Hello {text}";
        }

        
        public string SayHi(string text){
            return $"Hi {text}";
        }

        
        public string SayWelcom(string text){
            return $"Welcom {text}";
        }
    }
}
