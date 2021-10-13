namespace my_zoo
{
    class Dog : Mammal
    {
        public override int NumLegs => 4;

        public override bool BabyIsNursed => true;

        public override string Eats()
        {
            return "I eat kibble";
        }

        public override string MakeSound()
        {
            return "I like to Woof-Woof at squirrels";
        }
    }
}