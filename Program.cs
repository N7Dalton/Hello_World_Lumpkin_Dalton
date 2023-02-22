using System;

namespace Hello_World_Lumpkin_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for first name
            Console.WriteLine("What is your first name?");

            //assigns answer to the string firstname
            string firstname = Console.ReadLine();

            //asks for last name
            Console.WriteLine("and your last name?");

            //assigns answer to the string last name 
            string lastname = Console.ReadLine();

            //says they are weird
            Console.WriteLine($"So your name is {firstname} {lastname}? weirdo.");
        }
    }
}
