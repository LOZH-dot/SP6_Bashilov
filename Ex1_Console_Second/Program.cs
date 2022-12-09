using System;

namespace Ex1_Console_Second
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int xSize, ySize;

            int[,] arr;

            while (true)
            {
                try
                {
                    Console.Write("Введите целое число: ");
                    number = int.Parse(Console.ReadLine());

                    Console.Write("Введите размерность массива (x): ");
                    xSize = int.Parse(Console.ReadLine());

                    Console.Write("Введите размерность массива (y): ");
                    ySize = int.Parse(Console.ReadLine());

                    if (xSize <= 0 || ySize <= 0) throw new Exception("Размер массива должен быть больше нуля!");

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

            arr = new int[xSize, ySize];

            while (true)
            {
                try
                {
                    for (int i = 0; i < xSize; i++)
                        for (int j = 0; j < ySize; j++)
                        {
                            Console.Write($"Введите [{i + 1}][{j + 1}] элемент массива: ");
                            arr[i, j] = int.Parse(Console.ReadLine());
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

            Console.WriteLine("\nПолучившийся массив:");
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    Console.Write($"[{arr[i, j]}] ");
                }
                Console.WriteLine();
            }

            Console.Write($"\nНомера элементов массива, которые больше {number}: ");
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                    if (arr[i, j] > number) Console.Write($"[{i + 1}][{j + 1}] ");
            }
            Console.WriteLine();
        }
    }
}
