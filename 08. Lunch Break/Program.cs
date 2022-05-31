using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Име на сериал – текст
            //2.Продължителност на епизод  – цяло число в диапазона[10… 90]
            //3.Продължителност на почивката  – цяло число в диапазона[10… 120]
            string nameOfSeries = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());
            double timeForLunch = breakDuration / 8.0;
            double timeForRest = breakDuration / 4.0;
            double timeLeft = breakDuration - timeForLunch - timeForRest;
            double difference = timeLeft - episodeDuration;
            if (difference>=0)
            {
                Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {Math.Ceiling(difference)} more minutes.");
            }
        } 
    }
}
