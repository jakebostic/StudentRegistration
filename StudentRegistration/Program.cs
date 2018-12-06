using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();

            Console.WriteLine("Enter first name: ");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            var lname = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            var bdate = Console.ReadLine();

            var name = fname + " " + lname;
            var pass = fname + "*" + bdate;

            Console.WriteLine($"\nWelcome {name}!");
            Console.WriteLine("\nYour registration is complete.");
            Console.WriteLine($"\nYour temporary password is: {pass}");
            Console.WriteLine();

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);

        }
    }
}