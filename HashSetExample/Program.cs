/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;
using System.Collections.Generic;

namespace HashSetExample
{
    /// <summary>
    /// Unordered collection of items.
    /// Uses tags or attributes that may be applied to a data item.
    /// Methods:
    /// * Add
    /// * Remove
    /// * RemoveWhere
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var RobotA = new HashSet<string> { "Case", "CPU", "SSD", "RAM" };

            var RobotB = new HashSet<string>();
            RobotB.Add("Case");

            var StandardConfig = new HashSet<string> { "CPU", "SSD", "RAM" };
            if (StandardConfig.IsSubsetOf(RobotA)) { Console.WriteLine("Robot A has the standard configuration."); }
            if (StandardConfig.IsSubsetOf(RobotB)) { Console.WriteLine("Robot B has the standard configuration."); }

            Console.ReadKey();
        }
        public void Init()
        {
            HashSet<string> setInit = new HashSet<string> { "CPU", "SSD", "RAM" };
        }
    }
}
