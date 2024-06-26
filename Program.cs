using System;
using System.Threading;

namespace CountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of seconds for the countdown: ");
            int seconds;
            while (!int.TryParse(Console.ReadLine(), out seconds) || seconds < 0)
            {
                Console.Write("Please enter a valid positive integer: ");
            }

            for (int i = seconds; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine("Countdown Timer: {0} seconds", i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Time's up!");
        }
    }
}
