using System;

namespace Ex1_Console_First
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int[] arr;
            int size = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите целое число: ");
                    number = int.Parse(Console.ReadLine());

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

            arr = new int[size];

            while (true)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Введите {i + 1}-й элемент массива: ");
                        arr[i] = int.Parse(Console.ReadLine());
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

            Console.Write($"\nНомера элементов массива, которые больше {number}: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > number) Console.Write($"[{i + 1}] ");
            }
            Console.WriteLine();
        }
    }
}
