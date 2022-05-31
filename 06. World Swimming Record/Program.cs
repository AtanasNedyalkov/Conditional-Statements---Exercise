using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());
            double middleTIme = distanceInMeters * timeInSeconds;
            double additionalTime = (Math.Floor(distanceInMeters / 15)) * 12.5;
            double finalTime = middleTIme + additionalTime;
            if (finalTime >= recordInSeconds)
            {
                double difference = finalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }

        }
    }
}
