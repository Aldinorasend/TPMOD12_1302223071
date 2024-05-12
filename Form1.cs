using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP12_1302223071_NEW
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

        private void button1_Click(object sender, EventArgs e)
        {
            int parameterValue;
            if (!int.TryParse(textBox1.Text, out parameterValue))
            {

                return;
            }

            string result = CariTandaBilangan(parameterValue);

            label1.Text = result;
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0)
            {
                return "Bilangan Negatif";

            }
            else if (a > 0)
            {
                return "Bilangan Positif";
            }
            else
            {
                return "Nol";
            }
        }

        
    }
}
