using System;

namespace Task1_2Library
{
    public class Task1_2
    {
        public static void Start()
        {
            Console.WriteLine("\nЗадание 2: Заданы два массива А и В." +
                "Первым на печать вывести массив, сумма значений которого окажется наименьшей. ");

            int A_size = ReadPositiveInt("Введите размер массива А: ");
            int B_size = ReadPositiveInt("Введите размер массива B: ");

            float[] A = new float[A_size];
            float[] B = new float[B_size];
            double sum_A = 0, sum_B = 0;

            Console.WriteLine("\nВведите элементы массива А:");
            for (int i = 0; i < A_size; i++)
            {
                A[i] = ReadFloat($"A[{i}] = ");
                sum_A += A[i];
            }

            Console.WriteLine("\nВведите элементы массива B:");
            for (int i = 0; i < B_size; i++)
            {
                B[i] = ReadFloat($"B[{i}] = ");
                sum_B += B[i];
            }

            if (sum_A > sum_B) Console.WriteLine($"\nСумма элементов массива A = {sum_A}");
            else if (sum_A < sum_B) Console.WriteLine($"\nСумма элементов массива B = {sum_B}");
            else Console.WriteLine($"\nСумма элементов массива A = {sum_A}\n" +
                $"Сумма элементов массива B = {sum_B}");
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
