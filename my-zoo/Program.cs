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
                Console.WriteLine(IIsPet);
                Console.WriteLine(IIsScary);
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
            Console.WriteLine();

            Snake snake = new Snake();
            Console.WriteLine("Hi, I am a Snake!");
            WriteAnimal(snake);
            Console.WriteLine();

            Turtle turtle = new Turtle();
            Console.WriteLine("Hi, I am a Turtle!");
            WriteAnimal(turtle);
            Console.WriteLine();
        }
    }
}