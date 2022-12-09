using System;
using System.Windows.Forms;

namespace Ex3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string[] strs = ElementsTextBox.Text.Split(' ');
            int xSize = 0, ySize = 0;

            int[,] arr;

            try
            {
                xSize = int.Parse(XTextBox.Text);
                ySize = int.Parse(YTextBox.Text);

                if (xSize <= 0 || ySize <= 0) throw new Exception("Размер массива должен быть больше нуля!");

                arr = new int[xSize, ySize];

                int iterator = 0;
                for (int i = 0; i < xSize; i++)
                {
                    for (int j = 0; j < ySize; j++)
                    {
                        int number = int.Parse(strs[iterator]);
                        arr[i, j] = number;
                        iterator++;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ожидается ввод целых чисел элементов массива и числа для проверки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"Количество элементов массива должно быть {xSize * ySize}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "Получившийся массив:\n";
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    result += $"[{arr[i, j]}] ";
                }
                result += "\n";
            }

            int norm = 0;
            for (int i = 0; i < xSize; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < ySize; j++)
                    if (arr[i, j] > max) max = arr[i, j];

                norm += max;
            }

            result += $"Норма матрицы: {norm}";
            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
