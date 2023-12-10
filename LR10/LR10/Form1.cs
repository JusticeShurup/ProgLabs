using System.Net.Http.Json;

namespace LR10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxP.Visible = true;
            labelP.Visible = true;


            textBoxC.Visible = false;
            labelC.Visible = false;
            textBoxB.Visible = false;
            labelB.Visible = false;
            textBoxR.Visible = false;
            labelR.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxP.Visible = false;
            labelP.Visible = false;

            textBoxC.Visible = true;
            labelC.Visible = true;
            textBoxB.Visible = true;
            labelB.Visible = true;
            textBoxR.Visible = true;
            labelR.Visible = true;
        }

        private void TextBoxDoubleValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1 && (sender as TextBox).Text.Length >= 1))
            {
                e.Handled = true;
            }
        }

        private void TextBoxIntValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private double FirstMethodCalculate(int N, double p)
        {
            int prev = 2;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += i % 2 == 0 ? -1 : 1 * Math.Pow(p, i + 2) / prev * (i + 3);
                prev *= (i + 3);
            }

            return sum;
        }

        private double SecondMethodCalculate(int N, int R, double b, double c)
        {
            double sum = 0;

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < R; j++)
                {
                    sum += (Math.Pow(i, 2) + b * j) / c * Math.Pow(i, 3);
                }
            }

            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 0;
            if (!int.TryParse(textBoxN.Text, out N))
            {
                MessageBox.Show("Вы ввели неккоректное число N", "Ошибка!");
                return;
            }
            if (FirstMethod.Checked)
            {
                double P = 0;
                if (!double.TryParse(textBoxP.Text, out P))
                {

                    MessageBox.Show("Вы ввели неккоректное число P", "Ошибка!");
                    return;
                }
                Text = FirstMethodCalculate(N, P).ToString();
            }
            else if (SecondMethod.Checked)
            {
                int R = 0;
                if (!int.TryParse(textBoxR.Text, out R))
                {
                    MessageBox.Show("Вы ввели неккоректное числа R", "Ошибка!");
                    return;
                }


                double b = 0;
                double c = 0;

                if (!double.TryParse(textBoxC.Text, out c) || !double.TryParse(textBoxB.Text, out b))
                {
                    MessageBox.Show("Вы ввели неккоректное числа B или C", "Ошибка!");
                    return;
                }

                Text = SecondMethodCalculate(N, R, b, c).ToString();
            }
        }

    }
}