using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Видеокарта – 250 лв./ бр.
            //•	Процесор – 35 % от цената на закупените видеокарти/ бр.
            //•	Рам памет – 10 % от цената на закупените видеокарти/ бр
            //            1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            //2.Броят видеокарти - цяло число в интервала[0…100]
            //3.Броят процесори - цяло число в интервала[0…100]
            //4.Броят рам памет -цяло число в интервала[0…100]
            double budget = double.Parse(Console.ReadLine());
            int numOfVideoCards = int.Parse(Console.ReadLine());
            int numOfCpus = int.Parse(Console.ReadLine());
            int numOfRams = int.Parse(Console.ReadLine());

            int videoCard = 250;
            int priceOfVideoCards = numOfVideoCards * videoCard;
            double cpu = numOfCpus*(priceOfVideoCards * 0.35);
            double ram = numOfRams*(priceOfVideoCards * 0.10);

            double finalSum = priceOfVideoCards + cpu + ram;
            if (numOfVideoCards > numOfCpus)
            {
                finalSum = finalSum - finalSum * 0.15;
            }
            double difference = budget - finalSum;
            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
        }
    }
}
