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

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             *  
             * Creatively display the class member values 
             */
            Animal animal = new Animal();


            Bird bird = new Bird();

            bird.feathers = true;
            bird.beak = true;
            bird.wings = true;
            bird.legs = 4;
            bird.age = 1;
            bird.name = "Timmy";
            bird.Food = "Seeds";
            Console.WriteLine($"Here is a story of my bird {bird.name}.  It is {bird.wings} he has.. Hopefully two Wings.");
            Console.WriteLine();
            Console.WriteLine();





            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            Reptile reptile = new Reptile();
            reptile.name = "Johnny";
            reptile.scales = "Many";
            reptile.slipperyTongue = true;
            reptile.tail = "yes";
            reptile.claws = true;
            reptile.feathers = false;
            reptile.wings = false;
            reptile.age = 5;
            reptile.Food = "Creepy things";
            Console.WriteLine($" This is a second story about a reptile named {reptile.name}. it has {reptile.scales} scales. Eww. \n" +
                $"it's {reptile.slipperyTongue} it does have a slippery tongue. does it have a tail you ask? yes , {reptile.tail} it does.");



            Console.WriteLine("Lets now display all the animals we have in an array that i do not know how to create without copying lol.");
            Console.WriteLine();
            Console.WriteLine();

            Animal[] collection = new Animal[2];

            collection[0] = animal;
            collection[0] = bird;
            collection[1] = reptile;

    
            foreach( var item in collection)
            {
                Console.WriteLine($"stated name : {item.name}");
                Console.WriteLine($"questionable age : {item.age}");
                Console.WriteLine();
               
                Console.WriteLine($"what do they eat ? {item.Food}");
                Console.WriteLine();
            }

        }
    }
}
