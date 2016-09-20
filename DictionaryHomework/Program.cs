using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();

            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Fish", 0);
            animals.Add("Cat", 4);
            animals.Add("Octopus", 8);

            
            if(animals.ContainsKey("Bear"))
            {
                int value = animals["Bear"];
                Console.WriteLine("Bear has " + value + " legs.");
            }

            if(animals.ContainsKey("Dog"))
            {
                int value = animals["Dog"];
                Console.WriteLine("Dog has " + value + " legs");
            }

            if(animals.ContainsKey("Octopus"))
            {
                int value = animals["Octopus"];
                Console.WriteLine("Octopus has " + value + " legs");
            }
            
            string animalName = "Cat";

            if(animals.ContainsKey(animalName)) 
            {
                int value = animals[animalName];
                Console.WriteLine(animalName+ " has "+value+" legs ");
            }
        }
    }
}
