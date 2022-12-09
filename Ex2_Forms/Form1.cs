using System;
using System.Windows.Forms;

namespace Ex2_Forms
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

            int size = strs.Length;

            double[] arr = new double[size];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    double number = double.Parse(strs[i]);

                    arr[i] = number;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ожидается ввод действительных чисел элементов массива!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "Получившийся массив: ";

            for (int i = 0; i < arr.Length; i++)
            {
                result += ($"{arr[i]} ");
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

            result += ($"\nПолучившийся массив, где первый минимальный элемент и последний максимальный поменяны местами: ");
            for (int i = 0; i < arr.Length; i++)
            {
                result += ($"{arr[i]} ");
            }

            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
