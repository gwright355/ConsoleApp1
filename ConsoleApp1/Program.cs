using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");

            Console.ReadKey(true);

         try
            {
                string input = Console.ReadLine();
                Console.WriteLine("Your name is " + input);
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter valid data");



                Console.WriteLine("Press any key to exit the program and try again ...");

                Console.ReadKey(true);
            }
        }
    }
}
