namespace my_zoo
{
    public class Turtle : Reptile, IIsPet
    {
        public override string ScaleColor => "Green-ish?";

        public override bool LaysEggs => true;

        public bool IsPet { get; set; } = true;

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