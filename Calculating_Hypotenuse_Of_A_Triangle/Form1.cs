namespace Calculating_Hypotenuse_Of_A_Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side1 =Convert.ToDouble(textBox1.Text);
            double side2 =Convert.ToDouble(textBox2.Text);
            double hypo = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            textBox3.Text = hypo.ToString();
            
        }
    }
}
