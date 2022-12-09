using System;

namespace Ex3_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize, ySize;

            int[,] arr;

            while (true)
            {
                try
                {
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

            int norm = 0;
            for (int i = 0; i < xSize; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < ySize; j++)
                    if (arr[i, j] > max) max = arr[i, j];

                norm += max;
            }

            Console.WriteLine($"\nНорма матрицы: {norm}");
        }
    }
}
