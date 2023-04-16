namespace Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.textBox1.Text = this.textBox1.Text;
            result.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result result = new Result();

            string ageString = textBox2.Text;
            int age;

            if (!int.TryParse(ageString, out age))
            {
                MessageBox.Show("Пожалуйста, введите число для возраста.");
                textBox2.Focus();
                return;
            }
            else
            {
                result.textBox1.Text = this.textBox2.Text;
                result.ShowDialog();
            } 
        }
    }
}