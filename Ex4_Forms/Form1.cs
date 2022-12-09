using System;
using System.Windows.Forms;

namespace Ex4_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            string[] Sizes = SizeTextBox.Text.Split(' ');

            string[] strs = ElementsTextBox.Text.Split(' ');

            int size = Sizes.Length;

            int[][] arr = new int[size][];
            int[] resultArr = new int[size];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int subSize = int.Parse(Sizes[i]);
                    arr[i] = new int[subSize];
                }

                int iterator = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr[i][j] = int.Parse(strs[iterator]);
                        iterator++;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ожидается ввод целых чисел элементов массива и размерности строк массива!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"Неверное количество элементов массива!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "Получившийся массив:\n";

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

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result += ($"[{arr[i][j]}] ");
                }
                result += "\n";
            }

            result += ("\nРезультат поиска отрицательных элементов в строках (-1 - отрицательный элемент не найден):");
            for (int i = 0; i < arr.Length; i++)
            {
                result += ($"[{resultArr[i]}] ");
            }


            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
