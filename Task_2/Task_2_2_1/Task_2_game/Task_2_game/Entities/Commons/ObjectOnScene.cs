//Все объекты в сцене

namespace Task_2_game
{
    public abstract class ObjectOnScene
    {
        public abstract Point centerOfObject { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Sprite { get; set; }
    }
}
