using System;
using Xunit;

namespace MyZoo.Tests
{
    public class ZooTests
    {
        [Fact]
        public void Dog_does_animal_things()
        {
            
            Animal animal = new Dog();


            Assert.Equal("I like to woof-woof at squirrels", animal(MakeSound());

        }
    }
}

