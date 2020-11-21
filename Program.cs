using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string firstName = "Brian";
            string greeting = "Hello";
            string message = $"{greeting} {firstName}";

            Console.WriteLine(message + "!");
            
            Console.WriteLine("The current time is: " + DateTime.Now);
            
            string projectName = "Test123";
            Console.WriteLine($@"C:\output\{projectName}\Data");


        }
    }
}
