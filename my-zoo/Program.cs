using System;

namespace my_zoo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            static void WriteAnimal(Animal animal)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine(animal.Eats());

                if (animal is Mammal mammal)
                {
                    WriteMammal(mammal);
                }
                if (animal is Reptile reptile)
                {
                    WriteReptile(reptile);
                }
            }

            static void WriteMammal(Mammal mammal)
            {
                if (mammal is IIsPet ispet)
                {
                    Console.WriteLine($"It is {ispet.IsPet} that I make for a good pet!");
                }

                Console.WriteLine($"It is {mammal.BabyIsNursed} that I nurse my babies!");
            }

            static void WriteReptile(Reptile reptile)
            {
                Console.WriteLine($"My scales are {reptile.ScaleColor}!");
                Console.WriteLine($"It is {reptile.LaysEggs} that I lay eggs!");
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Hello! Welcome to my zoo! Lets meet all of our animals!");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();

            Cow cow = new Cow();
            Console.WriteLine("Hi, I am a Cow!");
            WriteAnimal(cow);
            Console.WriteLine();


            Dog dog = new Dog();
            Console.WriteLine("Hi, I am a Dog!");
            WriteAnimal(dog);
            Console.WriteLine();

            Monkey monkey = new Monkey();
            Console.WriteLine("Hi, I am a Monkey!");
            WriteAnimal(monkey);
            Console.WriteLine();

            Alligator alligator = new Alligator();
            Console.WriteLine("Hi, I am a Alligator!");
            WriteAnimal(alligator);
            Console.WriteLine($"It is {alligator.IsScary} that I am very scary!");
            Console.WriteLine();

            Snake snake = new Snake();
            Console.WriteLine("Hi, I am a Snake!");
            WriteAnimal(snake);
            Console.WriteLine($"It is {snake.IsScary} that I am very scary!");
            Console.WriteLine();
           

            Turtle turtle = new Turtle();
            Console.WriteLine("Hi, I am a Turtle!");
            WriteAnimal(turtle);
            Console.WriteLine($"It is {turtle.IsPet} that I make for a good pet!");
            Console.WriteLine();
        }
    }
}