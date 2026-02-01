using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_degisken_yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alan, kisakenar, uzunkenar;
            kisakenar = 10;
            uzunkenar = 20;
            alan = kisakenar * uzunkenar;
            label1.Text = "Alan:" + alan;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc1, sonuc2, sonuc3,toplamsonuc;
            sonuc1 = 79;
            sonuc2 = 82;
            sonuc3 = 56;
            toplamsonuc = sonuc1 + sonuc2 + sonuc3 ;
            label2.Text = "Sınav Sonucu:" + toplamsonuc/3;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
