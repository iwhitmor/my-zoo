namespace my_zoo
{ 
    class Monkey : Mammal

    {
        public override int NumLegs => 2;

        public override bool BabyIsNursed => true;

        public override string Eats()
        {
            return "I love to eat Bananas";
        }

        public override string MakeSound()
        {
            return "I Howl when I am happy";
        }
    }
}