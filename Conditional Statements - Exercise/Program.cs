using System;

namespace Conditional_Statements___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int secondes = totalTime % 60;
            if (secondes < 10)
            {
                Console.WriteLine($"{minutes}:0{secondes}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secondes}");
            }
        }
    }
}
