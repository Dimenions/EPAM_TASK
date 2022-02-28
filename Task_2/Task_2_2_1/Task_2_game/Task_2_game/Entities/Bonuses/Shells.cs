using System;

//Снаряды как доп бонус

namespace Task_2_game
{
    class Shells : AbstactBonus
    {
        public override Point centerOfObject { get; set; }

        public Shells(Point center)
        {
            centerOfObject = center;
        }

        public override double AccrualOfExperience()
        {
            throw new NotImplementedException();
        }

        public double GetShells()
        {
            throw new NotImplementedException();
        }
    }
}
