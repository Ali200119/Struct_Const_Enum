using System;
using Service.Interfaces;

namespace Service
{
    public class Calculate : ICalculate
    {
        public int Multiply(params int[] array)
        {
            int result = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 1 && array[i] < 20)
                {
                    result *= array[i];
                }
            }

            return result;
        }

        public int SumPow(params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum * sum;
        }
    }
}