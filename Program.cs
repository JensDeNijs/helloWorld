using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string pickName;
            int pickAge;


            Console.WriteLine("What is your name");

            pickName = Console.ReadLine();

            Console.WriteLine("hi " + pickName + ", what is the amount of years you have?");

            pickAge = Convert.ToInt32(Console.ReadLine());

            if (pickAge > 25)
            {
                Console.WriteLine(pickAge + " is way to many years to have.");
            }
            else
            {
                Console.WriteLine(pickAge + " is a good amount of years to have.");
            }
        }
    }
}
