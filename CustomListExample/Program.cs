using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListExample
{
    /// <summary>
    /// Example of a class inheriting a List<T>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Robots r = Robots.GetRobots();
            r.RemoveRobot("Optimus");
            Console.WriteLine(r);
            Console.ReadKey();
        }

        class Robot
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        class Robots : List<Robot>
        {
            public int RemoveRobot(string FirstName)
            {
                var removeList = new List<Robot>();
                foreach (Robot p in this)
                {
                    if (p.FirstName == FirstName)
                    {
                        removeList.Add(p);
                    }
                }

                foreach (Robot p in removeList)
                {
                    this.Remove(p);
                }

                return removeList.Count;
            }

            public override string ToString()
            {
                var s = new StringBuilder();
                foreach (Robot p in this)
                {
                    s.AppendFormat("FirstName:{0} LastName:{1} Age:{2}\n",
                        p.FirstName, p.LastName, p.Age);
                }

                return s.ToString();
            }

            public static Robots GetRobots()
            {
                return new Robots() {
                    new Robot() { FirstName = "Optimus", LastName = "Prime", Age = 40 },
                    new Robot() { FirstName = "R2", LastName = "D2", Age = 32 },
                    new Robot() { FirstName = "C", LastName = "3P0", Age = 14 }
                };
            }
        }
    }
}
