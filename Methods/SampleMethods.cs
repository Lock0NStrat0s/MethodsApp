using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

public static class SampleMethods
{
    public static void SayHi(string firstName)
    {
        Console.WriteLine($"Hello {firstName}.");
        Console.WriteLine("Hope you are having a good day!");
    }

    public static string GetUsersName()
    {
        Console.Write($"What is your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Tuple
    public static (string firstName, string lastName) GetFullName()
    {
        Console.Write($"What is your first name: ");
        string firstName = Console.ReadLine();
        Console.Write($"What is your first name: ");
        string lastName = Console.ReadLine();

        return (firstName, lastName);
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye user.");
        Console.WriteLine("See you again!");
    }
}
