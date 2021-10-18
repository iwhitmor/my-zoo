namespace my_zoo
{
    public class Alligator : Reptile, IIsScary
    {
        public override string ScaleColor => "Green";

        public override bool LaysEggs => true;

        public bool IsScary { get; set; } = true;

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