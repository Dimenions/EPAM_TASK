using System.Collections.Generic;


namespace Task_2_game
{
    public class GameHandler
    {
        List<AbstractEnemies> enemies = new List<AbstractEnemies>();
        List<AbstactBonus> bonuses = new List<AbstactBonus>();
        List<AbstractObstacle> obstacles = new List<AbstractObstacle>();

        // В workingSpace надо хранить объекты которые входят в сцену

        ObjectOnScene[,] workingSpace/* = new ObjectOnScene[n, m]*/;

        // инициализация объектов
        public GameHandler()
        {

        }

        //Update
        public void NextFrame()
        {

        }
    }
}
