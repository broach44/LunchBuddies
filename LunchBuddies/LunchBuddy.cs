using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurant.Name}");
            return restaurant.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Some {FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat(List<string> companions)
        {
            var restaurant = new Restaurant();

            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with...");
            companions.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });
        }

        public void Eat(string food, List<string> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} ordered {food} and shared with {companions[0]}");

        }
    }
}
