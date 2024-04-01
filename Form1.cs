namespace oop17
{
    public partial class OOP17 : Form
    {
        Hyperbola hyper = new Hyperbola(); // створення обєкту класу Hyperbola

        Ellipse elips = new Ellipse(0, 0, 3, 5); // створення обєкту класу Ellipse (ініціалізація через конструктор)

        public OOP17()
        {
            InitializeComponent();
        }

        private void button_hyperbola_Click(object sender, EventArgs e)//обчислення y для гіперболи
        {
            try
            {
                label_hyperbola.Text = hyper.Calculate(Convert.ToDouble(textBox_hyperbola.Text)).ToString();
            }
            catch (FormatException)//захист
            {
                MessageBox.Show("Тільки числа");
            }
        }

        private void button_elips_Click(object sender, EventArgs e)//обчислення y для еліпса
        {
            try
            {
                label_elipse.Text = elips.Calculate(Convert.ToDouble(textBox_elipse.Text)).ToString();
            }
            catch (FormatException)//захист
            {
                MessageBox.Show("Тільки числа");
            }
        }
    }
}
