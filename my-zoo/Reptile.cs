namespace my_zoo
{
    public abstract class Reptile : Animal
    {
        public override string ToString()
        {
            return base.ToString() + " and a Reptile";
        }

        public abstract string ScaleColor { get; }

        public virtual bool LaysEggs { get; }

        public override bool HasHair => false;
    }
}