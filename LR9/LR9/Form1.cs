namespace LR9
{
    public partial class Form1 : Form
    {
        private double f = 0;
        private double w = 0;
        private double t = 1;

        public Form1()
        {
            InitializeComponent();
        }


        private void TextBoxValidation(object sender, KeyPressEventArgs e)
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

        private void Calculate(object sender, EventArgs e)
        {
            if (textBoxF.Text.Length == 0 || textBoxW.Text.Length == 0 || textBoxT.Text.Length == 0 )
            {
                MessageBox.Show("Заполните ваши текстовые поля", "Ошибка!");
                return;
            }
            f = double.Parse(textBoxF.Text);
            w = double.Parse(textBoxW.Text);
            t = double.Parse(textBoxT.Text);

            if (t == 0)
            {
                MessageBox.Show("t не может быть равно 0", "Ошибка!");
                return;
            }

            double result = Math.Log10(f) - Math.E + Math.Abs(Math.Sin(w/t) + Math.Sqrt(Math.Abs(Math.E)));

            this.Text = result.ToString();

        }
    }
}