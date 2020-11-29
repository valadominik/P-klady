using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prumer = 0;int cislo,pocet=0;
            foreach(Control textbox in groupBox1.Controls)
            {
                if (textbox is TextBox)
                {
                    if (textbox.Text != "")
                    {
                        cislo = Convert.ToInt32(textbox.Text);
                        prumer += cislo;
                        pocet++;
                    }
                }
            }
            if (pocet!=0)
            {
                prumer /= pocet;
                label5.Text = "Průměr ze zadaných čísel je: " + Convert.ToString(prumer);
                label5.Visible = true;
            }
            else
            {
                label5.Text = "Nelze vypočítat průměr";
                label5.Visible = true;
            }
            pocet = listBox1.SelectedItems.Count;
            if (pocet != 0)
            {
                string slovo = listBox1.SelectedItem.ToString();
                foreach (Control label in groupBox1.Controls)
                {
                    if (label is Label)
                    {
                        label.Text = slovo;
                    }
                }
            }
            else
            {
                string slovo = "nic jsi nevybral";
                foreach (Control label in groupBox1.Controls)
                {
                    if (label is Label)
                    {
                        label.Text = slovo;
                    }
                }
            }
        }
    }
}
