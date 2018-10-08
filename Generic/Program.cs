using System;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrList<double> arr = new ArrList<double>(3);
            
            arr.Add(3.2);
            arr.Add(6.9);
            arr.Add(18.4);

            ArrList<string> arr2 = new ArrList<string>(2);
            arr2.Add("mohamed");
            arr2.Add("Ahmed");

            Console.WriteLine(arr.GetByIndex(2));
            Console.WriteLine(arr2.GetByIndex(1));

            Console.ReadLine();
        }
    }


    class ArrList<T>{
        private T[] priArr;
        private int intIndex = 0;
        
        public ArrList(int size){
            priArr = new T[size];
        }

        public void Add(T value){
            priArr[intIndex] = value;
            intIndex ++ ;
        }

        public T GetByIndex(int index){
            return priArr[index];
        }
    }
}
