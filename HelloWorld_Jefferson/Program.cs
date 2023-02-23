//system namespace needed to use console class.
using System;
// my collection of classes for this project
namespace HelloWorld_Jefferson
{
    //main class for our program
    class Program
    {
        //the main method is executed when application starts
        static void Main(string[] args)
        {
            //asks for the user's name
            Console.WriteLine("What is your first name?");
            //assigns user input to firstname
            string firstname = Console.ReadLine();

            //asks for the user's last name
            Console.WriteLine("What is your last name?");
            //assigns user input to lastname
            string lastname = Console.ReadLine();

            //prints a welcome message with the user's first and last name
            Console.WriteLine($"Hello, {firstname} {lastname} ");
        }
    }
}
