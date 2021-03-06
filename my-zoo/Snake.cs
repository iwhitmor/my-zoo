namespace my_zoo
{
    public class Snake : Reptile, IIsScary, IIsPet
    {
        public override string ScaleColor => "Multiple Colors!";

        public override bool LaysEggs => true;

        public bool IsScary { get; set; } = true;

        public bool IsPet { get; set; } = true;

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