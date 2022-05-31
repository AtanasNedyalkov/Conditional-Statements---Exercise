using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Декорът за филма е на стойност 10 % от бюджета.
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            //Вход
            //От конзолата се четат 3 реда:
            //            Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            double filmBudget = double.Parse(Console.ReadLine());
            int numOfStatists = int.Parse(Console.ReadLine());
            double priceForClothsStatist = double.Parse(Console.ReadLine());
            double decorPrice = filmBudget * 0.1;
            if (numOfStatists>= 150)
            {
               priceForClothsStatist =  priceForClothsStatist - priceForClothsStatist * 0.1;
            }
            double totalPriceCloths = priceForClothsStatist * numOfStatists;
            double totalPrice = totalPriceCloths + decorPrice;
            double difference = filmBudget - totalPrice;
            if (difference>=0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }
        }
    }
}
