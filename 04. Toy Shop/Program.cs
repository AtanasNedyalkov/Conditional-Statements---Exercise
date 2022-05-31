using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double doll = 3;//•	Говореща кукла -3 лв.
            double bear = 4.10;//•	Плюшено мече -4.10 лв.
            double minion = 8.20;//•	Миньон - 8.20 лв.
            double truck = 2;//•	Камионче - 2 лв.
           
            double holidayPrice = double.Parse(Console.ReadLine());
            int numOfPuzzels = int.Parse(Console.ReadLine());
            int numOfDolls = int.Parse(Console.ReadLine());
            int numOfBears = int.Parse(Console.ReadLine());
            int numOfMinions = int.Parse(Console.ReadLine());
            int numOfTrucks = int.Parse(Console.ReadLine());
            double totalPrice = numOfPuzzels * puzzle + numOfDolls * doll + numOfBears * bear + numOfMinions * minion + numOfTrucks * truck;
            int totalNumOfToys = numOfBears + numOfDolls + numOfMinions + numOfPuzzels + numOfTrucks;
            if (totalNumOfToys >= 50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }
            
            double rent = totalPrice * 0.1;
            double totalPriceAfterRent = totalPrice - rent;
            if (holidayPrice<=totalPriceAfterRent)
            {
                double moneyLeft = totalPriceAfterRent - holidayPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = holidayPrice - totalPriceAfterRent;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }


        }
    }
}
