//Абстрактный вражина

namespace Task_2_game
{
    public abstract class AbstractEnemies : ObjectOnScene
    {
        public abstract double Health { get; set; }
        public abstract double Speed { get; set; }
        public abstract double Damage { get; set; }
        public abstract double Review { get; set; }
    }
}
