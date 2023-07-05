// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine(a-b + "\n");
        Console.WriteLine(a+b);
        Console.WriteLine(a/b);
        Console.WriteLine(a*b);
        Console.WriteLine(a%b);


        Console.WriteLine(a>b);
        Console.WriteLine(a<b);
        Console.WriteLine(a==b);
        Console.WriteLine(a!=b);
        Console.WriteLine(a>=b);
       Console.WriteLine(a<=b);

        // and  or  not 
        Console.WriteLine("Logical Operators");

        Console.WriteLine(true && true); 
        Console.WriteLine(true && false); 
        Console.WriteLine(true || false); 
        Console.WriteLine(!false);
        Console.WriteLine(++a);




    }
}