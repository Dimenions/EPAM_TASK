using System;

namespace Task3_3
{
    public static class MyDelegates
    {
        public static int FloorDivide(int firstNum, int secondNum)
        {
            if (firstNum == 0 || secondNum == 0)
            {
                return 0;
            }

            return (int)Math.Floor((double)firstNum / secondNum);
        }

        public static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public static int Power(int num, int power)
        {
            return (int)Math.Pow(num, power);
        }
    }
}
