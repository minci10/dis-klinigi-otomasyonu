using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class RANDEVU_EKRANI : Form
    {
        public RANDEVU_EKRANI()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void txt_randevu_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void txt_randevu_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_randevu_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void RANDEVU_EKRANI_Load(object sender, EventArgs e)
        {
            
        }

    

        private void btn_randevuolustur_Click(object sender, EventArgs e)
        {
            dateTimePicker_suan.Value = DateTime.Now;
            //eğer tc kayıtlı değilse randevu eklerken hastayı aynı zamanda kayıt edeceğiz
            con = new SqlConnection("Server=.;Database=DIS_KLINIGI;Trusted_Connection=True;");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM HASTA_BILGILERI WHERE TC='" + txt_randevu_tc.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_control.Text = dr["Ad"].ToString();
            }
            if (txt_control.Text == "")
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into HASTA_BILGILERI (TC,Ad,Soyad,Ev_Tel,Cep_Tel,Dogum_Yeri,Yasadigi_Il_ID,Yasadigi_Ilce_ID,Kurum_ID) values (" + txt_randevu_tc.Text + ",'" + txt_randevu_ad.Text + "','" + txt_randevu_soyad.Text + "','" + txt_randevu_evtel.Text + "','" + txt_randevu_ceptel.Text + "',0,0,0,20)";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Hasta Eklendi");
                }
            //randevu eklenecek
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into RANDEVU (TC,Randevu_Tarih,Olusturma_Tarihi) values (" + txt_randevu_tc.Text.ToString() + ",'" + dateTimePicker_randevutarih.Text + "','" + dateTimePicker_suan.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("RANDEVU EKLENDI");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            txt_control.Text = "";
            txt_randevu_ad.Text = "";
            txt_randevu_ceptel.Text = "";
            txt_randevu_evtel.Text = "";
            txt_randevu_soyad.Text = "";
            txt_randevu_tc.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void select(TextBox txt,string sorgu,string sutunadi)
        {   con = new SqlConnection("Server=.;Database=DIS_KLINIGI;Trusted_Connection=True;");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { txt.Text = dr[sutunadi].ToString(); }
            else
            {txt.Text = "";}
            con.Dispose();
            con.Close(); }

        private void txt_randevu_tc_KeyUp(object sender, KeyEventArgs e)
        {  //eğer randevu ekranında girilen tc varsa boş alanları otomatik doldursun
            try
            {
                if (txt_randevu_tc.Text.Length == 11)
                {
                    select(txt_randevu_ad, "SELECT * FROM HASTA_BILGILERI where TC='" + txt_randevu_tc.Text + "'", "Ad");
                    select(txt_randevu_soyad, "SELECT * FROM HASTA_BILGILERI where TC='" + txt_randevu_tc.Text + "'", "Soyad");
                    select(txt_randevu_ceptel, "SELECT * FROM HASTA_BILGILERI where TC='" + txt_randevu_tc.Text + "'", "Cep_Tel");
                    select(txt_randevu_evtel, "SELECT * FROM HASTA_BILGILERI where TC='" + txt_randevu_tc.Text + "'", "Ev_Tel");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString());
                throw; }
        }
    }
    }
    