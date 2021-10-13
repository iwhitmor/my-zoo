namespace my_zoo
{
    class Alligator : Reptile
    {
        public override string ScaleColor => "Green";

        public override bool LaysEggs => true;

        public override string Eats()
        {
            return "I enjoy eating fish";
        }

        public override string MakeSound()
        {
            return "I bellow loudly";
        }
    }
}