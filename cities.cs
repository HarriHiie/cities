using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>();
            {
                {"Harju", "Tallinn"},
                {"Läänemaa", "Haapsalu"},
                {"Raplamaa", "Rapla"},
            };

            cities.Remove("Harju");

            if (cities.ContainsKey("Läänemaa"))
            {
                cities.Remove("Läänemaa");
            }

            Console.WriteLine("total elements: {0}", cities.Count);
        }
    }
}
