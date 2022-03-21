using System;


namespace Task_1_3
{
    public class Human : ICloneable
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public object Clone()
        {
            return new Human() { Name = this.Name };
        }
    }
}
