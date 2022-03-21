using System;

namespace CustomStringsClass
{
    public class CustomString
    {
        private char[] _сustomString;

        public int Length
        {
            get
            {
                return _сustomString.Length;
            }
        }

        //--------------Конструкторы---------------------------------
        public CustomString()
        {
            _сustomString = new char[100];
        }

        public CustomString(int value)
        {
            _сustomString = new char[value];
        }

        public CustomString(char[] array)
        {
            _сustomString = new char[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                _сustomString[i] = array[i];
            }
        }
        //-------------------------------------------------------------------

        //------------------------Методы-----------------------------------
        public char SearchLine(char chr)
        {

            for (int i = 0; i < Length; i++)
            {
                if (_сustomString[i] == chr)
                    return _сustomString[i];
            }

            throw new InvalidOperationException("Введённый элемент не найден");
        }

        public CustomString Insert(int index, char chr)
        {
            if (index > _сustomString.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Неверный индекс у строки");
            }
            else
            {
                char[] arr = new char[Length + 1];

                int currentIndex = 0;
                for (int i = 0; i < arr.Length; i++, currentIndex++)
                {
                    if (index == i)
                    {
                        arr[i] = chr;
                        --currentIndex;
                    }
                    else
                    {
                        arr[i] = _сustomString[currentIndex];
                    }
                }

                return new CustomString(arr);
            }
        }

        public CustomString Remove(int index)
        {
            if (index > _сustomString.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Неверный индекс у строки");
            }
            else
            {
                char[] arr = new char[Length - 1];

                int currIndex = 0;
                for (int i = 0; i < arr.Length; i++, currIndex++)
                {
                    if (index == i)
                    {
                        ++currIndex;
                        arr[i] = _сustomString[currIndex];
                    }
                    else
                    {
                        arr[i] = _сustomString[currIndex];
                    }
                }
                return new CustomString(arr);
            }
        }

        public char[] ToArray()
        {
            char[] toReturn = new char[_сustomString.Length];

            for (int i = 0; i < _сustomString.Length; i++)
            {
                toReturn[i] = _сustomString[i];
            }

            return toReturn;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            CustomString custStr = obj as CustomString;
            if (custStr is null)
                return false;

            return this == custStr;
        }

        public override string ToString()
        {
            return new string(_сustomString);
        }

        //Для сравнения строк
        public char this[int index]
        {
            get
            {
                if (index > _сustomString.Length || index < 0)
                    throw new IndexOutOfRangeException("Неверный индекс у строки");
                else
                    return _сustomString[index];
            }
            set
            {
                if (index > _сustomString.Length || index < 0)
                    throw new IndexOutOfRangeException("Неверный индекс у строки");
                else
                    _сustomString[index] = value;
            }
        }

//---------------------Операторы------------------------------
        private static bool IsEqual(CustomString str1, CustomString str2)
        {
            bool isEqual = true;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    isEqual = false;
            }

            return isEqual;
        }

        public static bool operator ==(CustomString str1, CustomString str2)
        {
            if (str1.Length != str2.Length)
                return false;

            return IsEqual(str1, str2);
        }

        public static bool operator !=(CustomString str1, CustomString str2)
        {
            if (str1.Length != str2.Length)
                return true;

            return IsEqual(str1, str2) ? false : true;
        }

        public static CustomString operator +(CustomString str1, CustomString str2)
        {
            char[] tempString = new char[str1.Length + str2.Length];

            int currentIndex = 0;

            for (int i = 0; i < str1.Length; i++, currentIndex++)
            {
                tempString[currentIndex] = str1[i];
            }

            for (int i = 0; i < str2.Length; i++, currentIndex++)
            {
                tempString[currentIndex] = str2[i];
            }

            return new CustomString(tempString);
        }
    }
}