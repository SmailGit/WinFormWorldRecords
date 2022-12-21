namespace WinFormWorldRecords
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Admin" & textBox2.Text == "admin") {
                Form form1 = new Form2();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не правильно введён логин или пароль");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}