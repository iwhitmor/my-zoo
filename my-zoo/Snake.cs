﻿namespace my_zoo
{
    class Snake : Reptile
    {
        public override string ScaleColor => throw new System.NotImplementedException();

        public override bool LaysEggs => true;

        public override string Eats()
        {
            return "Rodents";
        }

        public override string MakeSound()
        {
            return "Hiss";
        }
    }
}