namespace my_zoo
{
    class Turtle : Reptile
    {
        public override string ScaleColor => throw new System.NotImplementedException();

        public override bool LaysEggs => true;

        public override string Eats()
        {
            return "I love to eat insects";
        }

        public override string MakeSound()
        {
            return "I can grunt";
        }
    }
}