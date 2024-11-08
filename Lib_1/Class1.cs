using System;
using System.Threading;
namespace Lib_2
{
    public class Class2
    {
        public static void Function(ref int sum, int[] mas)
        {
            sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 5)
                {
                    sum = sum + mas[i];

                }
            }
        }
        public static void Massiv(out int[] mas, int N)
        {
            Random rnd = new Random();
            mas = new int[N];
            for (int i = 0; i < N; i++)
                mas[i] = rnd.Next(N + 1);
        }

    }
}

