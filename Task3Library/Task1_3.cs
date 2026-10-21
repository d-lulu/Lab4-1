using System;

namespace Task1_3Library
{
    public class Task1_3
    {
        public static void Start()
        {
            Console.WriteLine("\nЗадание 3: Дан массив A(n,n)." +
                "Найти сумму всех его элементов, расположенных выше главной диагонали.");

            int n = ReadPositiveInt("Введите n: ");
            float[,] A = new float[n, n];

            Console.WriteLine("\nВведите элементы массива:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = ReadFloat($"A[{i}, {j}] = ");
            

            float sum = 0;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    sum += A[i, j];
                }

            Console.WriteLine($"Сумма элементов выше главной диагонали: {sum}");
        }


        private static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                    return value;
                Console.WriteLine("Ошибка! Введите целое число больше 0.\n");
            }
        }

        private static float ReadFloat(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out float value))
                    return value;
                Console.WriteLine("Ошибка! Введите число.");
            }
        }
    }
}
