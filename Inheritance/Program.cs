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
            Animal animal = new Animal();

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */
            Bird bird = new Bird();
            bird.canFly = true;
            bird.colorFeathers = "black";
            bird.isTrainable = true;
            bird.type = "Eagle";
            bird.canHunt = true;
            bird.name = "Mike";
            bird.hasOwner = true;

            if(bird.canFly && bird.canHunt && bird.hasOwner)
            {
                Console.WriteLine($"Wow, {bird.name} the {bird.colorFeathers} {bird.type} can really fly, must be a great hunter. Its owner must be a great trainer.");
            } else if(bird.canHunt == false && bird.canFly)
            {
                Console.WriteLine($"This {bird.type} with the {bird.colorFeathers} feathers must only eat bird seeds.");
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            Reptile reptile = new Reptile();
            reptile.canWalk = true;
            reptile.slithers = false;
            reptile.hasScale = true;
            reptile.isFast = true;
            reptile.name = "Sally";
            reptile.hasOwner = false;
            reptile.type = "Alligator";
            reptile.color = "White";

            if(reptile.canWalk && reptile.hasScale && reptile.isFast)
            {
                Console.WriteLine($"Wow, {reptile.name} the {reptile.type} has {reptile.hasScale} is very fast and can find food.");
            } else if(reptile.canWalk == false && reptile.hasScale)
            {
                Console.WriteLine($"This {reptile.type} with the {reptile.color} scales must be a great burrower.");
            }

        }
    }
}
