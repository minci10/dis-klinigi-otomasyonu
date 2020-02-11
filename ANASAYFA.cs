using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
         

        }

        private void btn_hastabilgiekrani_Click(object sender, EventArgs e)
        {
            HASTA_BILGI form = new HASTA_BILGI();

            form.Show();
        }

        private void btn_randevuekrani_Click(object sender, EventArgs e)
        {
            RANDEVU_EKRANI form2 = new RANDEVU_EKRANI();
            form2.Show();
        }

        private void btn_muayeneekrani_Click(object sender, EventArgs e)
        {
            MUAYENE_EKRANI form3 = new MUAYENE_EKRANI();
            form3.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kasaekrani_Click(object sender, EventArgs e)
        {
            KASA_EKRANI form4 = new KASA_EKRANI();
            form4.Show();
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 asd = new Form3();
            asd.Show();
        }
    }
}
