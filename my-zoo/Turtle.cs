namespace my_zoo
{
    class Turtle : Reptile
    {
        public override string ScaleColor => throw new System.NotImplementedException();

        public override bool LaysEggs => true;

        public override string Eats()
        {
            return "Insects";
        }

        public override string MakeSound()
        {
            return "Grunt";
        }
    }
}