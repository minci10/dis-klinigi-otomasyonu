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
    public partial class KASA_EKRANI : Form
    {
        public KASA_EKRANI()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void txt_kasaekrani_gelirtutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_gelir_Click(object sender, EventArgs e)
        {
            insertupdatedelete("insert into KASA (Islem_Turu,Odeme_Turu,Tutar,Aciklama,Hasta_Kabul_ID) values ('GELİR','" + cmb_kasaekrani_odemeturu.SelectedIndex + "'+1,'" + txt_kasaekrani_gelirtutar.Text + "','" + txt_aciklama.Text + "','" + lbl_hastakabulid.Text + "')");

            foreach (DataGridViewRow drow in datagridview_kasa.SelectedRows)  
            {
                int numara = Convert.ToInt32(drow.Cells[5].Value);
                string sql = "UPDATE HASTA_KABUL SET ONAY='1' WHERE Hasta_Kabul_ID="+numara;
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Hasta_Kabul_ID", numara);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            griddoldur("SELECT hk.TC,hb.Ad,hb.Soyad,hk.Tarih,i.Ucret,hk.Hasta_Kabul_ID FROM HASTA_KABUL hk,HASTA_BILGILERI hb,ISLEMLER i,HASTALARA_YAPILAN_ISLEMLER hyi where hyi.Islem=i.Islem_ID and hyi.Hasta_Kabul_ID = hk.Hasta_Kabul_ID and hk.TC=hb.TC and hk.Onay='0'", "HASTA_KABUL", datagridview_kasa);
            txt_tc.Text = "";
            txt_kasaekrani_gelirtutar.Text = "";
            txt_aciklama.Text = "";
            cmb_kasaekrani_odemeturu.Text = "";

           
        }
        public void insertupdatedelete(string sorgu)
        {
            
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void cmbgetir(string sorgu, ComboBox cmb, string sutunadi)
        {
            //comboboxlara veri getirme
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
            cmd = new SqlCommand();
            cmd.CommandText = sorgu;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr[sutunadi]);
            }
            con.Close();
        }
        void griddoldur(string sorgu, string tablo, DataGridView dtg)
        {
            //dgw doldur
            con = new SqlConnection("server=.; Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI");
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, tablo);
            dtg.DataSource = ds.Tables[tablo];
            con.Close();
        }

        private void KASA_EKRANI_Load(object sender, EventArgs e)
        {
            cmbgetir("SELECT * FROM ODEME_TURLERI",cmb_kasaekrani_odemeturu,"Odeme_Tur_Adi");
            griddoldur("SELECT hk.TC,hb.Ad,hb.Soyad,hk.Tarih,i.Ucret,hk.Hasta_Kabul_ID FROM HASTA_KABUL hk,HASTA_BILGILERI hb,ISLEMLER i,HASTALARA_YAPILAN_ISLEMLER hyi where hyi.Islem=i.Islem_ID and hyi.Hasta_Kabul_ID = hk.Hasta_Kabul_ID and hk.TC=hb.TC and hk.Onay='0'", "HASTA_KABUL",datagridview_kasa);
        }
        
        private void tabControl1_kasaekrani_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1_kasaekrani.SelectedIndex == 1)
            {
                griddoldur("SELECT Islem_Turu,Tutar,Aciklama FROM KASA WHERE Islem_Turu='GİDER'","KASA", datagridview_kasa);

            }
            if (tabControl1_kasaekrani.SelectedIndex == 0)
            {
                griddoldur("SELECT hk.TC,hb.Ad,hb.Soyad,hk.Tarih,i.Ucret,hk.Hasta_Kabul_ID FROM HASTA_KABUL hk,HASTA_BILGILERI hb,ISLEMLER i,HASTALARA_YAPILAN_ISLEMLER hyi where hyi.Islem=i.Islem_ID and hyi.Hasta_Kabul_ID = hk.Hasta_Kabul_ID and hk.TC=hb.TC and hk.Onay='0'", "HASTA_KABUL", datagridview_kasa);

            }
            if (tabControl1_kasaekrani.SelectedIndex == 2)
            {             
                griddoldur("SELECT * FROM KASA ORDER BY Islem_ID desc","KASA",datagridview_kasa);
            }
        }

        private void datagridview_kasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_hastakabulid.Text = datagridview_kasa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_tc.Text = datagridview_kasa.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            if (txt_tc.Text.Length == 11)
            {
                griddoldur("SELECT hk.TC,hb.Ad,hb.Soyad,hk.Tarih,i.Ucret,hk.Hasta_Kabul_ID FROM HASTA_KABUL hk,HASTA_BILGILERI hb,ISLEMLER i,HASTALARA_YAPILAN_ISLEMLER hyi where hyi.Islem=i.Islem_ID and hyi.Hasta_Kabul_ID = hk.Hasta_Kabul_ID and hk.TC=hb.TC and hk.TC like '"+txt_tc.Text+"' and hk.Onay = '0'", "HASTA_KABUL", datagridview_kasa);
            }
            if (txt_tc.Text.Length == 0)
            {
                griddoldur("SELECT hk.TC,hb.Ad,hb.Soyad,hk.Tarih,i.Ucret,hk.Hasta_Kabul_ID FROM HASTA_KABUL hk,HASTA_BILGILERI hb,ISLEMLER i,HASTALARA_YAPILAN_ISLEMLER hyi where hyi.Islem=i.Islem_ID and hyi.Hasta_Kabul_ID = hk.Hasta_Kabul_ID and hk.TC=hb.TC and hk.Onay='0'", "HASTA_KABUL", datagridview_kasa);
            }
        }

        private void btn_kasaekrani_giderekle_Click(object sender, EventArgs e)
        {
            insertupdatedelete("insert into KASA (Islem_Turu,Tutar,Aciklama) values ('" + tabPage2.Text + "','" + txt_kasaekrani_gidertutar.Text + "','" + txt_kasaekrani_gideraciklama.Text + "')");
            txt_kasaekrani_gidertutar.Text = "";
            txt_kasaekrani_gideraciklama.Text = "";
            MessageBox.Show("TUTAR DEFTERE EKLENDI...");
            griddoldur("SELECT Islem_Turu,Tutar,Aciklama FROM KASA WHERE Islem_Turu='GİDER'", "KASA", datagridview_kasa);
        }
    }
}
