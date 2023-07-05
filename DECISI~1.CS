// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // int marks = 61;
        // if statement

        // if (marks > 90){
        //      Console.WriteLine("A grade");
        //  }

        // if else statement
        // if (marks > 90){
        //      Console.WriteLine("A grade");
        //  }
        //  else {
        //      Console.WriteLine("Fail");
        //  }
        
        //Nested if statement

        int x = 6; 
        if (x%2 == 0){
            if (x%3 == 0){
                Console.WriteLine("Number is divisible by 2 and 3");

            }
        }
       
    // if else if else statement

        if (marks  > 90){
            Console.WriteLine("A1 Grade");
        }
        else if (marks > 80){
            Console.WriteLine("B Grade");
        }
        else if (marks > 70){
            Console.WriteLine("C Grade");

        }
        else if (marks > 60){
            Console.WriteLine("D Grade");

        }
         else{
            Console.WriteLine("Fail");    

         }


// Switch Statement

        string n  = "One";
        switch(n){
            case "One":
                Console.WriteLine("One value of n");
            break;

            case "Two":
            Console.WriteLine("Two value of n");
            break;

            case "Jafri":
            Console.WriteLine("Jafri value of n");
            break;
        
            default:
                Console.WriteLine("Not matching....");
                break;

        }


    }
}