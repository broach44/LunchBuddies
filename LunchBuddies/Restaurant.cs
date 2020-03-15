using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> RestaurantNames { get; set; }
        // string below should pick a random restaurant name and assign it to public property called "Name"
        public string Name { get; set; }

        public Restaurant()
        {
            var restaurants = new List<string>()
            {
                "Panera",
                "Prince's Hot Chicken",
                "Five Guys Burgers and Fries",
                "Vui's Kitchen",
                "Outback Steakhouse",
                "Texas Roadhouse"
            };

            RestaurantNames = restaurants;

            Random rnd = new Random();
            int r = rnd.Next(RestaurantNames.Count);
            Name = RestaurantNames[r];
        }

        public void WhereAmI()
        {
            Console.WriteLine($"I am currently visiting {Name}");
        }
    }
}
