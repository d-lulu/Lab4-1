using System;
using Task1_1Library;
using Task1_2Library;
using Task1_3Library;
using Task1_4Library;

namespace LAB4
{
    class Programm
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("МЕНЮ");
                Console.WriteLine("1.Задание 1.1");
                Console.WriteLine("2.Задание 1.2");
                Console.WriteLine("3.Задание 1.3");
                Console.WriteLine("4.Задание 1.4");
                Console.WriteLine("0.Выход");
                Console.WriteLine("Ваш выбор: ");

                if (!(int.TryParse(Console.ReadLine(), out int choice)))
                    Console.WriteLine("Ошибка! Введите целое число от 0 до 3. \n");

                else
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Выход из программы. До свидания!");
                        break;
                    }

                    switch (choice)
                    {
                        case 1:
                            Task1_1.Start();
                            break;
                        case 2:
                            Task1_2.Start();
                            break;
                        case 3:
                            Task1_3.Start();
                            break;
                        case 4:
                            Task1_4.Start();
                            break;
                        default:
                            break;
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}