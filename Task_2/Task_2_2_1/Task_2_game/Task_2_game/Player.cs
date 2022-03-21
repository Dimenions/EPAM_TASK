//Игрок

namespace Task_2_game
{
    public class Player : ObjectOnScene, IMovable
    {
        public override Point centerOfObject { get; set; }

        public Player(Point center)
        {
            centerOfObject = center;
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
