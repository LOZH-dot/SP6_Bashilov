using System;
using System.Windows.Forms;

namespace Ex1_Forms_First
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
            int checkNumber = 0;

            int[] arr = new int[size];

            try
            {
                checkNumber = int.Parse(NumberTextBox.Text);

                for (int i = 0; i < arr.Length; i++)
                {
                    int number = int.Parse(strs[i]);
                    arr[i] = number;
                }
            }
            catch
            {
                MessageBox.Show("Ожидается ввод целых чисел элементов массива и числа для проверки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "Получившийся массив: ";

            for (int i = 0; i < arr.Length; i++)
            {
                result += $"{arr[i]} ";
            }

            result += ($"\nНомера элементов массива, которые больше {checkNumber}: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > checkNumber) result += ($"[{i + 1}] ");
            }

            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
