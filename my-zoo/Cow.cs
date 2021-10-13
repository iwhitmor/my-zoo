namespace my_zoo
{
    class Cow : Mammal
    {
        public override int NumLegs => 4;

        public override bool BabyIsNursed => true;

        public override string Eats()
        {
            return "Hay";
        }

        public override string MakeSound()
        {
            return "Moooo";
        }
    }
}