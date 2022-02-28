using System;
using System.Collections.Generic;
using System.Linq;
//Аптечка как доп бонус

namespace Task_2_game
{
    class Medicine : AbstactBonus
    {
            public override Point centerOfObject { get; set; }

            public Medicine(Point center)
            {
                centerOfObject = center;
            }

            public override double AccrualOfExperience()
            {
                throw new NotImplementedException();
            }

        public double RecoveryHP()
        {
            throw new NotImplementedException();
        }
    }
}
