namespace my_zoo
{
    class Monkey : Mammal

    {
        public override int NumLegs => throw new System.NotImplementedException();

        public override bool HasHair => throw new System.NotImplementedException();

        public override string Eats()
        {
            throw new System.NotImplementedException();
        }

        public override string MakeSound()
        {
            throw new System.NotImplementedException();
        }
    }
}