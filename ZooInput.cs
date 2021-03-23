using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class ZooInput
    {
        public List<ITalkable> GetZoo()
        {
            List<ITalkable> zoo = new List<ITalkable>();
            bool keepRunning = true;
            while (keepRunning)
            {
                string keepRunningInput;
                do {
                    Console.WriteLine("Want to add an animal to the zoo? (y/n)");
                    keepRunningInput = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(keepRunningInput) || 
                         !keepRunningInput.ToUpper().Equals("Y") && 
                         !keepRunningInput.ToUpper().Equals("N"));

                if (keepRunningInput.ToUpper().Equals("Y"))
                {
                    var animal = GetAnimal();
                    if (animal != null)
                    {
                        zoo.Add(animal);
                    }
                }
                else
                {
                    keepRunning = false;
                }

            }

            return zoo;
        }
        
        public ITalkable GetAnimal()
        {
            string name;
            do {
                Console.WriteLine("What is your animal's name?");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            
            Console.WriteLine("What kind of animal would you like to create?" +
                              "\n1. Dog" +
                              "\n2. Cat" +
                              "\n3. Teacher" +
                              "\n\nEnter any other character to quit");
            var input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input)) return null;
            
            switch (input)
            {
                // dog
                case "1":
                {
                    string friendlyInput;
                    do {
                        Console.WriteLine("Is your dog friendly? (y/n)");
                        friendlyInput = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(friendlyInput) || 
                             !friendlyInput.ToUpper().Equals("Y") && 
                             !friendlyInput.ToUpper().Equals("N"));

                    var friendly = friendlyInput.ToUpper().Equals("Y");
                    return new Dog(friendly, name);
                }
                // cat
                case "2":
                    string mousesKilledInput;
                    int mousesKilled;
                    do {
                        Console.WriteLine("How many mice has your cat killed?");
                        mousesKilledInput = Console.ReadLine();
                    } while (!int.TryParse(mousesKilledInput, out mousesKilled));
                    
                    return new Cat(mousesKilled, name);
                // teacher
                case "3":
                    string ageInput;
                    int age;
                    do {
                        Console.WriteLine("What is the teacher's age?");
                        ageInput = Console.ReadLine();
                    } while (!int.TryParse(ageInput, out age));
                    
                    return new Teacher(age, name);
                default:
                    return null;
            }
        }
    }
}