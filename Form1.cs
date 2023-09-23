namespace login_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txt1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txt2.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txt3.BackColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.txt1.BackColor= Color.White;
            this.txt2.BackColor = Color.White;
            this.txt3.BackColor = Color.White;

        }
    }
}