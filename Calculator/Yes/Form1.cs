using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        static double Logarithm(double number, double baseValue)
        {
            return Math.Log(number) / Math.Log(baseValue);
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            int rule = 20;
            int rule2 = 10;
            double baseVal = 2;
            double exponent = 3;
            double armor = Convert.ToDouble(InputArmor.Text);
            double health = Convert.ToDouble(InputHealth.Text);
            double power = Math.Pow(armor, exponent);
            double number = health * power;
            Console.WriteLine(number);
            //double equation = 6 + Logarithm(number, baseVal);
            if (health <= 80)
            {
                double equation = 6 + Logarithm(health * power, baseVal);
                Console.WriteLine(equation);
                BoxOutput.Text = (Convert.ToString(equation));
            }
            else if (health >= 800)
            {
                double equation = Math.Round(5.5 + Logarithm((health * power), baseVal), 2);
                Console.WriteLine(equation);
                BoxOutput.Text = (Convert.ToString(equation));

            }
            else
            {
                double equation = Math.Round(6 + Logarithm((health * power), baseVal), 2);
                Console.WriteLine(equation);
                BoxOutput.Text = (Convert.ToString(equation));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableOfToughnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
