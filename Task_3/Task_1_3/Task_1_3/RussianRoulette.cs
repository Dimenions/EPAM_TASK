using System;


namespace Task_1_3
{
    public class RussianRoulette<T>
    {
        CircleList<T> list;

        public int IndexDeleter { get; set; }

        private int CurrentIndex { get; set; }
        private int RoundCounter = 0;

        public RussianRoulette(int indexToDel, CircleList<T> list)
        {
            this.list = list;

            IndexDeleter = indexToDel;
            CurrentIndex = 0;

            CheckCorrect();
        }

        public void StartWeakestLink()
        {
            while (list.Length >= IndexDeleter)
            {
                list.RemoveAt(IndexDeleter);

                Game.PrintMessage($"Раунд {RoundCounter}. Один человек выбывает. Людей осталось: {list.Length}");


                CurrentIndex += IndexDeleter;
                RoundCounter += 1;
            }
        }

        private void CheckCorrect()
        {
            if (list.Length < IndexDeleter)
            {
                throw new Exception("Ошибка! Индекс больше количества пользователей!");
            }

            if (IndexDeleter < 0)
            {
                throw new IndexOutOfRangeException("Недопустимый индекс!");
            }
        }
    }
}
