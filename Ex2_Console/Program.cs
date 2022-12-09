using System;

namespace Ex2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr;
            int size = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите размерность массива: ");
                    size = int.Parse(Console.ReadLine());

                    if (size <= 0) throw new Exception("Размер массива должен быть больше нуля!");

                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Неверный формат ввода данных!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            arr = new double[size];

            while (true)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Введите {i + 1}-й элемент массива: ");
                        arr[i] = double.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Неверный формат ввода данных!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write($"\nПолучившийся массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }


            // поиск индекса последнего максимального элемента
            double max = arr[0];
            int maxIndex = 0;
            foreach (double num in arr)
                if (num > max) max = num;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == max) maxIndex = i;

            // поиск индекса первого минимального элемента
            double min = arr[0];
            int minIndex = 0;
            foreach (double num in arr) 
                if (num < min) min = num;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == min)
                {
                    minIndex = i;
                    break;
                }

            // меняем местами
            double temp = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = temp;

            // Вывод
            Console.Write($"\nПолучившийся массив, где первый минимальный элемент и последний максимальный поменяны местами: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
