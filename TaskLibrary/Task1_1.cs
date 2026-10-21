using System;

namespace Task1_1Library
{
    public class Task1_1
    {
        public static void Start()
        {
            Console.WriteLine("\nЗадание 1: Формирование массивов по правилу sqrt(n^k / (n+1)^k)");

            int n = ReadPositiveInt("Введите n: ");
            int m = ReadPositiveInt("Введите m: ");
            float k = ReadFloat("Введите случайное число k: ");

            double value = Math.Sqrt(Math.Pow(n, k) / Math.Pow(n + 1, k));

            double[] arr1 = new double[n];
            for (int i = 0; i < n; i++)
                arr1[i] = value;

            double[,] arr2 = new double[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr2[i, j] = value;

            Console.WriteLine("\nОдномерный массив:");
            for (int i = 0; i < n; i++)
                Console.Write($"{arr1[i]:F4}   ");
            Console.WriteLine();

            Console.WriteLine("\nДвумерный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{arr2[i, j]:F4}\t");
                Console.WriteLine();
            }

            Console.WriteLine();
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
                Console.WriteLine("Ошибка! Введите число.\n");
            }
        }
    }
}