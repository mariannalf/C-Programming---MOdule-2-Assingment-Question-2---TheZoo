using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Cage {i + 1}");
            Console.Write("What is the animal’s species? ");
            string species = Console.ReadLine();

            IAnimal animal;
            if (species.ToLower() == "lion")
            {
                animal = new Lion();
            }
            else if (species.ToLower() == "wolf")
            {
                animal = new Wolf();
            }
            else if (species.ToLower() == "bear")
            {
                animal = new Bear();
            }
            else
            {
                Console.WriteLine("Invalid species.");
                continue;
            }

            Console.Write("How old is it? ");
            animal.Age = int.Parse(Console.ReadLine());
            animal.RequestUniqueCharacteristic();

            animals.Add(animal);
        }

        Console.WriteLine("===== Animal Details =====");
        for (int i = 0; i < animals.Count; i++)
        {
            Console.WriteLine($"Cage {i + 1} contains {animals[i].GetDescription()}.");
        }
    }
}
