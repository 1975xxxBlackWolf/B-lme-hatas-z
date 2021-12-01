using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bölme_hatasız
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla = (sayi1+sayi2);
            label1.Text = sayi1+" + "+sayi2 + "=" + topla;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int cikra = (sayi1 - sayi2);
            label1.Text = sayi1 + " - " + sayi2 + "=" + cikra;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int carp = (sayi1 * sayi2);
            label1.Text = sayi1 + " x " + sayi2 + "=" + carp;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi2==0)
            {  
                label1.Text = "Bu sayıyı Bölemem Gardaş";
            }
            else
            {
                int bol = (sayi1 / sayi2);
                label1.Text = sayi1 + " / " + sayi2 + "=" + bol;
            }
            
        }
    }
}
