namespace my_zoo
{
    abstract class Animal

    {
        public override string ToString()
        {
            return "I am an Animal";
        }
        public abstract string Eats();

        public abstract string MakeSound();

        public abstract bool HasHair { get; }
    }
}