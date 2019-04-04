using System;

namespace TimeOfDay
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 12 && hour < 18)
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
