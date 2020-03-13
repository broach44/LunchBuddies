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
            var Restaurant = "Some Sample Restaurant"; // grab a random restaurant to return
            return Restaurant;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Some employee ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            // select random restaurant
            // print to console that employee is at restaurant
            // output the first name of each lunch buddy in list
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            // select ranom restaurant
            // print to console employee at the restaurant
            // order the specified food
            // and the first name of the teammates specified in the list
        }
    }
}
