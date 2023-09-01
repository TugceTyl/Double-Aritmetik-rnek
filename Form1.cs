using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Aritmetik_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2;
            double toplam, fark, çarpım, bölüm;

            sayı1=Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);

            toplam = sayı1 + sayı2;
            fark = sayı1 - sayı2;
            çarpım = sayı1 * sayı2;
            bölüm = sayı1 / sayı2;

            LblToplam.Text = toplam.ToString();
            LblFark.Text = fark.ToString();
            LblÇarpım.Text = çarpım.ToString();
            LblBölüm.Text = bölüm.ToString();

        }
    }
}
