using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lunch Buddies!");

            var restaurant1 = new Restaurant();
            restaurant1.WhereAmI();

            var companionsForLunchBuddy = new List<string>()
            {
                "Fred",
                "Samantha",
                "Chris",
                "Ava"
            };
            

            var lunchBuddy = new LunchBuddy("Bryce", "Lander");
            lunchBuddy.Eat();
            lunchBuddy.Eat("sushi");
            lunchBuddy.Eat(companionsForLunchBuddy);
            lunchBuddy.Eat("steak", companionsForLunchBuddy);



            Console.ReadLine();
        }
    }
}
