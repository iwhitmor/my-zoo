using System;

namespace my_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow();
            Console.WriteLine(cow);
            Console.WriteLine(cow.MakeSound());
            Console.WriteLine(cow.Eats());

            Dog dog = new Dog();
            Console.WriteLine(dog);
            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(cow.Eats());

            Monkey monkey = new Monkey();
            Console.WriteLine(monkey);
        }
    }
}