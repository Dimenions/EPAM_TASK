using System;
using System.Collections.Generic;

namespace Task_1_3
{
    public class CircleList<T>
    {
        private List<T> objects;

        public int Length { get => objects.Count; }

        public CircleList(IEnumerable<T> list)
        {
            objects = new List<T>(list);
        }

        public void Add(T obj)
        {
            objects.Add(obj);
        }

        public void RemoveAt(int index)
        {
            var realIndex = this[index];
            objects.RemoveAt(realIndex);
        }

        public void PrintAll()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return objects;
        }

        private int this[int index]
        {
            get
            {
                if (index <= 0)
                {
                    throw new IndexOutOfRangeException("Не существует индекса со значение 0!");
                }
                else
                {
                    if (index <= Length)
                    {
                        return index - 1;
                    }
                    else if (index % Length == 0)
                    {
                        return Length - 1;
                    }
                    else
                    {
                        return (index % Length) - 1;
                    }
                }
            }
        }
    }
}
