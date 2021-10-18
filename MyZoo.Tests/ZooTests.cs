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
    }
}