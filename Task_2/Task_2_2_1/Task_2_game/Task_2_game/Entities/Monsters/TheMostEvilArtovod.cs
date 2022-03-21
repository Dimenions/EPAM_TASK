using System;
using System.Collections.Generic;
using System.Linq;
//Артовод как гдавный враг

namespace Task_2_game
{
    class TheMostEvilArtovod : AbstractEnemies, IMovable
    {
        public override Point centerOfObject { get; set; }

        public override double Damage { get; set; }
        public override double Health { get; set; }
        public override double Speed { get; set; }
        public override double Review { get; set; }

        public TheMostEvilArtovod(Point center)
        {
            centerOfObject = center;
        }

        public double Stun()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }
    }
}
