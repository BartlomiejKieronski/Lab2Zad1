using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plecM.Checked && checkBox1.Checked && checkBox2.Checked==false || plecK.Checked && checkBox1.Checked && checkBox2.Checked == false) 
            {
                float x;
                float y = 100;
                x = float.Parse(textBox1.Text);
                x = x - y ;

                label3.Text = "Standardowa waga to " + x+"kg";
            }
            else if (plecM.Checked && checkBox2.Checked && checkBox1.Checked == false)
            {
                float x;
                int y = 100;
                const double V = 0.9;
                float z = (float)V;
                float v = float.Parse(textBox1.Text);
                x = v;
                x = x - y;
                x= x* z;
                label3.Text = "Idealna waga to " + x + "kg";
            }
            else if (plecK.Checked && checkBox2.Checked && checkBox1.Checked == false)
            {
                float x;
                int y = 100;
                const double V = 0.85;
                float z = (float)V;
                x = float.Parse(textBox1.Text);
                x = x - y;
                x = x * z;
                label3.Text = "Idealna waga to " + x + "kg";
            }
            else if (plecM.Checked && checkBox1.Checked && checkBox2.Checked)
            {
                float x,k;
                int y = 100;
                const double V = 0.9;
                float z = (float)V;
                x = float.Parse(textBox1.Text);
                x = x - y;
                k = x;
                x = x * z;
                label3.Text = "Standardowa waga mężczyzny to: " + k + "kg " + "idealna waga mężczyzny to" +x+"kg";
            }
            else if (plecK.Checked && checkBox1.Checked && checkBox2.Checked)
            {
                float x, k;
                int y = 100;
                const double V = 0.85;
                float z = (float)V;
                x = float.Parse(textBox1.Text);
                x = x - y;
                k = x;
                x = x * z;
                label3.Text = "Standardowa waga kobiety to: " + k + "kg " + "idealna waga kobiety to" + x + "kg";
            }
            else
            {
                label3.Text = "Błędne dane";
            }
        }
    }
}
