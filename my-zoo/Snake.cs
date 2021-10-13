namespace my_zoo
{
    class Snake : Reptile
    {
        public override string ScaleColor => "Multiple Colors!";

        public override bool LaysEggs => true;

        public override string Eats()
        {
            return "I eat rodents";
        }

        public override string MakeSound()
        {
            return "I will hiss if you are nearby";
        }
    }
}