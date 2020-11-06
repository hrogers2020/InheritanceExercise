using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var myBird = new Bird();
            myBird.BirdName = "Dove";
            myBird.WingColor = "White";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;


            var lizard = new Reptile()
            {
                ReptileName = "Lizard",
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"{animal.AnimalName}:");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"The color of the animal is {animal.Color}");
                Console.WriteLine($"Does it have a tail?: {animal.HasTail}");
                Console.WriteLine($"");
            }
        }
    }
}
