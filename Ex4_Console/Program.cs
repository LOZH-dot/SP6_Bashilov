using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr;

            int size = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите количество строк массива: ");
                    size = int.Parse(Console.ReadLine());

                    if (size <= 0) throw new Exception("Размер массива должен быть больше нуля!");

                    arr = new int[size][];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        int subSize = 0;
                        Console.Write($"Введите размер массива {i + 1}-й строки: ");
                        subSize = int.Parse(Console.ReadLine());

                        arr[i] = new int[subSize];
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

            while (true)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr[i].Length; j++)
                        {
                            Console.Write($"Введите [{i + 1}][{j + 1}] элемент ступенчатого массива: ");
                            arr[i][j] = int.Parse(Console.ReadLine());
                        }
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

            int[] resultArr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < 0)
                    {
                        resultArr[i] = j + 1;
                        break;
                    }
                    if (j == arr[i].Length - 1)
                        resultArr[i] = -1;
                }
            }

            Console.WriteLine("\nПолучившийся массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"[{arr[i][j]}] ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nРезультат (-1 - отрицательный элемент не найден):");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{resultArr[i]}] ");
            }
        }
    }
}
