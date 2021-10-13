namespace my_zoo
{ 
    class Monkey : Mammal

    {
        public override int NumLegs => 2;

        public override bool BabyIsNursed => true;

        public override string Eats()
        {
            return "Bananas";
        }

        public override string MakeSound()
        {
            return "Howl";
        }
    }
}