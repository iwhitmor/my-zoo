using System;

namespace my_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow();
            Console.WriteLine("Hi, I am a Cow!");
            Console.WriteLine(cow);
            Console.WriteLine(cow.MakeSound());
            Console.WriteLine(cow.Eats());
            Console.WriteLine();

            Dog dog = new Dog();
            Console.WriteLine("Hi, I am a Dog!");
            Console.WriteLine(dog);
            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(cow.Eats());
            Console.WriteLine();

            Monkey monkey = new Monkey();
            Console.WriteLine("Hi, I am a Monkey!");
            Console.WriteLine(monkey);
            Console.WriteLine(monkey.MakeSound());
            Console.WriteLine(monkey.Eats());
            Console.WriteLine();

            Alligator alligator = new Alligator();
            Console.WriteLine("Hi, I am a Alligator!");
            Console.WriteLine(alligator);
            Console.WriteLine();

            Snake snake = new Snake();
            Console.WriteLine("Hi, I am a Snake!");
            Console.WriteLine(snake);
            Console.WriteLine();

            Turtle turtle = new Turtle();
            Console.WriteLine("Hi, I am a Turtle!");
            Console.WriteLine(turtle);
        }
    }
}