using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random nh = new Random();
            int cislo;
            for(int i = 1; i <= 10; i++)
            {
                cislo = nh.Next(0,11);
                listBox1.Items.Add(cislo);
            }
            label1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucet = 0;
            int p = 0;
            foreach (var list in listBox1.SelectedItems)
            {
                soucet += int.Parse(list.ToString());
                p++;
            }
            label1.Text = "Počet vybraných je " + p.ToString();
            label2.Text = "Soucet vybraných je " + soucet.ToString();
        }
  }
}

