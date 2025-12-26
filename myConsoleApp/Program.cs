// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Enter your name:");
    //     // String? name = Console.ReadLine();

    //     // Console.WriteLine("Hello, "+name +"!");

    //     int n = 12;

    //     // for(int i = 1; i < n; i += 2)
    //     // {
    //         if(n%2==0)
    //         {
    //             Console.WriteLine("It is not a prime no");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Yes it is a prime no");
    //         }
    //     // }

    //     // prime no divisible only by itself and 1.
    // }

    // Console.Write("Enter your age");
    // String? input = Console.ReadLine();

    // if(int.TryParse(input, out int age))
    //     {
    //         bool isAdult = age>=18;
    //         Console.WriteLine("Adult"+isAdult);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid Age");
    //     }
    // }

    double feet = double.Parse(Console.ReadLine());

    double cent = feet * 30.48;

    Console.WriteLine("Feet to centimeter is "+cent);


    }
}    

