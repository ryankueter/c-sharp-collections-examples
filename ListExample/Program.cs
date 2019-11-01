/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;
using System.Collections.Generic;

namespace ListExample
{
    /// <summary>
    /// List<T>
    /// Implement the ICollection and IList interfaces.
    /// Provides sorting.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new List<string>()
            {
                "WALL-E",
                "Gort",
                "Rosie"
            };
            robots.Add("Kryten");
            robots.Add("Robby ");

            for (int i = 0; i < robots.Count; i++)
            {
                Console.WriteLine(robots[i]);
            }

            robots[0] = "AWESOM-O";
            foreach (string name in robots) { Console.WriteLine(name); }

            Console.ReadKey();
        }
    }
}
