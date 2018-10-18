using System;
using System.Threading;
using System.Threading.Tasks;

namespace SyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
           ProgClick();
        }
        public async void ProgClick(){
            Task<int> task = new Task<int>(CountOfText);
            task.Start();
            Console.WriteLine("loading for write cout of character");
            int count = await task;
            Console.WriteLine("Count of Charachter : " + count.ToString());

        }

        public  int CountOfText(){
            int count = "dfg dfgdfgdfg dfgfdgfdgdfgdfgfdg dgfdfgdfg dfgdfg".Length;
            Thread.Sleep(5000);
            return count;
        }
    }
}
