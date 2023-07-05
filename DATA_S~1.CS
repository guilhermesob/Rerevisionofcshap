// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      string[] colors = {"yellow","gray","pink","green"};
    //   Console.WriteLine(colors[0]);
      
   
    //   Array.Reverse(colors);
          Array.Sort(colors);

         foreach (string i in colors){
           Console.WriteLine(i);
    
      }
      }
}