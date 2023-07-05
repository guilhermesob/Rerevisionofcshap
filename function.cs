using System;

namespace MyApplication
{
  class Program
  {
        // static void test1(int x, int y){
        //     Console.WriteLine(x + y);
        //     Console.WriteLine("This is the function");
        //     Console.WriteLine("another..");
        // }
        
        static void test1(int x, int y = 30){
            Console.WriteLine(x + y);
            Console.WriteLine("This is the function");
            Console.WriteLine("another..");
        }

    static void Main(string[] args)
    {
        test1(10);
        
    }
  }
}