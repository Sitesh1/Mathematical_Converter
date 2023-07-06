using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathematicsCalculation
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            double cm = int.Parse(textBox1.Text);
            double inch= cm * 0.393701;
            label4.Text = inch.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double inch = int.Parse(textBox2.Text);
            double cm = inch * 2.54;
            label5.Text = cm.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kg = int.Parse(textBox3.Text);
            double lbs = kg * 2.20462;
            label15.Text = lbs.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double lbs = double.Parse(textBox4.Text);
            double kg = lbs / 2.20462;
            label16.Text = kg.ToString();
        }
    }
}
