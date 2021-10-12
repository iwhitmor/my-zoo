namespace my_zoo
{
    class Alligator : Reptile
    {
        public override string ScaleColor => "Green";

        public override bool LaysEggs => true;

        public override string Eats()
        {
            return "Fish";
        }

        public override string MakeSound()
        {
            return "Bellow";
        }
    }
}