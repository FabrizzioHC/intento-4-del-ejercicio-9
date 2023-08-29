namespace intento_4_del_ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int num3 = int.Parse(this.num3.Text);
            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if ((num1 > num2) && (num1 > num3))
                {
                    lblrslt.Text = "el primer numero es el mayor";
                }
                else if ((num2 > num3) && (num2 > num1))
                {
                    lblrslt.Text = "el segundo numero es el mayor";
                }
                else
                {
                    lblrslt.Text = "el tercer numero es el mayor";
                }
            }
        }
    }
}