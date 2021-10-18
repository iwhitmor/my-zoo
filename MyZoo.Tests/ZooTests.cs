using Xunit;
using my_zoo;

namespace MyZoo.Tests
{
    public class ZooTests
    {
        [Fact]
        public void Dog_does_animal_things()
        {
            Animal animal = new Dog();

            Assert.Equal("I like to Woof-Woof at squirrels", animal.MakeSound());
        }

        [Fact]
        public void Monkey_does_animal_things()
        {
            Animal animal = new Monkey();

            Assert.Equal("I Howl when I am happy", animal.MakeSound());
        }

        [Fact]
        public void Cow_does_animal_things()
        {
            Animal animal = new Cow();

            Assert.Equal("I say Moooo", animal.MakeSound());
        }

        [Fact]
        public void Alligator_does_animal_things()
        {
            Animal animal = new Alligator();

            Assert.Equal("I bellow loudly", animal.MakeSound());
        }

        [Fact]
        public void Snake_does_animal_things()
        {
            Animal animal = new Snake();             

            Assert.Equal("I will hiss if you are nearby", animal.MakeSound());
        }

        [Fact]
        public void Turtle_does_animal_things()
        {
            Animal animal = new Turtle();

            Assert.Equal("I can grunt", animal.MakeSound());
        }

        [Fact]
        public void Turtle_is_a_pet()
        {
            Turtle turtle = new Turtle();

            Assert.True(turtle.IsPet);
        }

        [Fact]
        public void Snake_is_scary()
        {
            Snake snake = new Snake();

            Assert.True(snake.IsScary);
        }
    }
}