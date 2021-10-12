namespace my_zoo
{
    abstract class Mammal : Animal
    {
        public override string ToString()
        {
            return base.ToString() + " and a Mammal";
        }

        public abstract int NumLegs { get; }

        public virtual bool BabyIsNursed { get; }
    }
}