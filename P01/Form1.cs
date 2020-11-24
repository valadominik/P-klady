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
        private void button27_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (char x in textBox2.Text)
            {
                if (x != ' ' && x != '!' && x != '?' && x != '.' && x != ',')
                    message += (char)(x + 3);
                else message += x;
            }
            MessageBox.Show(message);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string pismena = "QERTYUIOPASDFGHJKLZXCVBNM .,?!";
            int i = 0;
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }

        private void click_pohyb(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }
    }
}
