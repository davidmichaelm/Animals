using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // var zoo = new List<ITalkable>()
            // {
            //     new Dog(true, "Bean"),
            //     new Cat(9, "Charlie"),
            //     new Teacher(44, "Stacy Read")
            // };
            
            var zooInput = new ZooInput();
            var zoo = zooInput.GetZoo();
            
            zoo.ForEach(thing => PrintOut(thing));
        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine($"{p.Name} says = {p.Talk()}");
        }
    }
}
