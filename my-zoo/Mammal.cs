namespace my_zoo
{
    public abstract class Mammal : Animal, IIsPet
    {
        public override string ToString()
        {
            return base.ToString() + " and a Mammal";
        }

        public abstract int NumLegs { get; }

        public virtual bool BabyIsNursed { get; }

        public override bool HasHair => true;

        public bool IsPet { get; set; } = true; 
    }
}