/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    /// <summary>
    /// First-in-first-out (FIFO) collection.
    /// Add things to queue using the Enqueue method.
    /// Remove things using Dequeue method.
    /// Peek allows you to find something at the top of the queue.
    /// Count properties provides the number of items.
    /// If you are going to pass work items from one thread to another, use the ConcurrentQueue collection.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var cyberqueue = new Queue<string>(new string[] 
            {
                "HAL", "Terminator"
            });

            cyberqueue.Enqueue("Optimus Prime");
            cyberqueue.Enqueue("Robot B-9");

            Console.WriteLine(cyberqueue.Dequeue());
            Console.WriteLine(cyberqueue.Dequeue());

            Console.ReadKey();
        }
    }
}
