using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            string pismena = " !?.,MNBVCXZLKJHGFDSAPOIUYTREWQ";
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char pismeno = Convert.ToChar((sender as Button).Text);
            textBox1.Text += pismeno;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string novepismeno = "";
            foreach (char pismeno in textBox1.Text)
            {
                if (pismeno >= 'A')
                {
                    if (pismeno <= 'W')
                    {
                        novepismeno += Convert.ToChar(pismeno + 3);
                    }
                    else
                    {
                        novepismeno += Convert.ToChar(pismeno - 23);
                    }
                }

            }
            textBox1.Text = novepismeno;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string novepismeno = "";
            foreach (char pismeno in textBox1.Text)
            {
                if (pismeno >= 'A')
                {
                    if (pismeno <= 'W')
                    {
                        novepismeno += Convert.ToChar(pismeno - 3);
                    }
                    else
                    {
                        novepismeno += Convert.ToChar(pismeno + 23);
                    }
                }

            }
            textBox1.Text = novepismeno;
        }
    }
}
