using System;

namespace TimeOfDay
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hour;
            Console.WriteLine("What time is it? Militarily speaking?");
            hour = Console.ReadLine();

            if (hour > 0000 && hour < 1200)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 1200 && hour < 1800)
            {
                Console.WriteLine("Its afternoon.");
            }
            else
            {
                Console.WriteLine("Its evening.");
            }
        }
    }
}
