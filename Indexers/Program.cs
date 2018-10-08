using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenArr arr = new EvenArr(10);
            arr[0] = 2;
            arr[1] = 6;
            Console.WriteLine(arr[1]);
            Console.ReadLine();
        }
    }

    class EvenArr{
        private int[] privateArray;

        public EvenArr(int size){
            privateArray = new int[size];
        }

        public int this[int index]
        {
            get { return privateArray[index] ; }
            set { if (value % 2 == 0)
            {
                privateArray[index] = value ;
            }
            else
            {
                throw new Exception("even numbers only is allowed");
            } }
        }
    }
}
