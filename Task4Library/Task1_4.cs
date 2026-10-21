using System;

namespace Task1_4Library
{
    public class Task1_4
    {
        public static void Start()
        {
            Console.WriteLine("\nЗадание 4: Сортировка элементов методом простого выбора.");

            int size = ReadPositiveInt("Введите размер массива: ");
            float[] arr = new float[size];

            Console.WriteLine("\nВведите элементы массива:");
            for (int i = 0; i < size; i++)
                arr[i] = ReadFloat($"arr[{i}] = ");

            Console.WriteLine("\nНе отсортированный массив:");
            for (int i = 0; i < size; i++)
                Console.Write($"{arr[i]}   ");
            Console.WriteLine();

            for (int i = 0; i < size - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                float temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("\nОтсортированный массив:");
            for (int i = 0; i < size; i++)
                Console.Write($"{arr[i]}   ");
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
                Console.WriteLine("Ошибка! Введите число.");
            }
        }
    }
}
