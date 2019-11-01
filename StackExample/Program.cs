/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;
using System.Collections.Generic;

namespace StackExample
{
    /// <summary>
    /// Last-in-first-out (LIFO) collection.
    /// Push method pushes items to the top.
    /// Pop removes items from the stack.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> cyberstack = new Stack<string>(new string[] { "Bishop", "Bender" });

            cyberstack.Push("Johnny 5");
            cyberstack.Push("Marvin ");

            Console.WriteLine(cyberstack.Pop());
            Console.WriteLine(cyberstack.Pop());

            Console.ReadKey();
        }
    }
}
