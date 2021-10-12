namespace my_zoo
{
    class Dog : Mammal
    {
        public override int NumLegs => 4;

        public override bool BabyIsNursed => true;

        public override string Eats()
        {
            return "Kibble";
        }

        public override string MakeSound()
        {
            return "Woof-Woof";
        }
    }
}