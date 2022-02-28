using System;

//Кусты

namespace Task_2_game.Entities
{
    class Bush : AbstractObstacle
    {
        public override Point centerOfObject { get; set; }

        public Bush(Point center)
        {
            centerOfObject = center;
        }

        public override bool Collision()
        {
            throw new NotImplementedException();
        }
    }
}
