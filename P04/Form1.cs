using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(comboBox1.SelectedItem);
            if(x!="")
            {
                int umocneni = Convert.ToInt32(x);
                label1.Text = "Umocnění: " + x;
                foreach(Control textbox in panel1.Controls)
                {
                    if(textbox is TextBox)
                    {
                        if(textbox.Text!="")
                        {
                            double vypocet = Convert.ToInt32(textbox.Text);
                            vypocet = Math.Pow(vypocet, umocneni);
                            textbox.Text = vypocet.ToString();
                        }
                    }
                }
            }
            else
            {
                label1.Text = "Nevybral jsi mocninu";
            }
        }
    }
}
