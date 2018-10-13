using System;

namespace MulticastDeleget
{
    public delegate void MSG();
    public delegate int GetSum(int value);
    public delegate void GetOut(out int value);
    
    class Program
    {
        static void Main(string[] args)
        {
            //1st example
            MSG msg1,msg2,msg3,msg4 ;
            msg1 = new MSG(ShowMessage1);
            msg2 = new MSG(ShowMessage2);
            msg3 = new MSG(ShowMessage3);

            msg4 = msg1 + msg2 + msg3 ;

            // msg4();
            //============================================================================

            //2nd example.

            MSG ms = new MSG(ShowMessage1);
            //register to another function.
            ms += ShowMessage2 ;
            //register to another function
            ms += ShowMessage3 ;
            //unregister from exist function
            ms -= ShowMessage2;


            //ms();
            //============================================================================

            //3rd example.
            GetSum num = new GetSum(GetSumWithFive);            
            num += GetSumWithTen ;
            num -= GetSumWithTen;
            int sum = num(15);
            //Console.WriteLine("Total is : {0}", sum);

            //============================================================================
            //4th example.
            GetOut go = new GetOut(GetOut5);
            go += GetOut10;
            int outValue = -1;
            go(out outValue);
            
            Console.WriteLine("The Output Value is : {0}",outValue);


        }




    public static void ShowMessage1(){
        Console.WriteLine("Hello 1");
    }

    
    public static void ShowMessage2(){
        Console.WriteLine("Hello 2");
    }

    
    public static void ShowMessage3(){
        Console.WriteLine("Hello 3");
    }


    public static int GetSumWithFive(int number){
        return 5 + number;
    }

     public static int GetSumWithTen(int number){
        return 10 + number;
    }


    public static void GetOut5(out int value){
        value = 5;
    }

    
    public static void GetOut10(out int value){
        value = 10;
    }


    } 

   

}
