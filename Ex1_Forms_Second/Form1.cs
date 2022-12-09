using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Forms_Second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int[,] arr;

            string[] strs = ElementsTextBox.Text.Split(' ');

            int xSize, ySize;
            int checkNumber;

            try
            {
                checkNumber = int.Parse(NumberTextBox.Text);
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

            result += ($"\nНомера элементов массива, которые больше {checkNumber}: ");
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                    if (arr[i, j] > checkNumber) result += $"[{i + 1}][{j + 1}] ";
            }

            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
