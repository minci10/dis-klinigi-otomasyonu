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
    public partial class MUAYENE_EKRANI : Form
    {
        public MUAYENE_EKRANI()
        {
            InitializeComponent();
              int ilac = 1;
              lbl_ilac_sayac.Text = ilac.ToString();
            
            
          

            }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        Label lblrandevu = new Label();
        private void btn_muayene_ilacekle_Click(object sender, EventArgs e)
        {
            numericUpDown_ilacsayi.Enabled = false;

            int i = Convert.ToInt32(lbl_ilac_sayac.Text);

                if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 1)
                {

                    

                        
lbl_muayene_1ilac.Visible = true;
                lbl_ilacbarkod1.Visible = true;
                        lbl_muayene_1ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                        lbl_ilacbarkod1.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                      
                    
                    
                }
                else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 2)
                {


                if (i == 1)
                {
                    lbl_muayene_1ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod1.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_1ilac.Visible = true;
                    lbl_ilacbarkod1.Visible = true;

                }
                if (i == 2)
                {
 lbl_muayene_2ilac.Visible = true;
                lbl_ilacbarkod2.Visible = true;
                lbl_muayene_2ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                        lbl_ilacbarkod2.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                }
                       

                      
                    
                }
                else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 3)
                {

               
               
                
                    if (i == 1)
                    {
lbl_muayene_1ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod1.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_1ilac.Visible = true;
                lbl_ilacbarkod1.Visible = true;
                    
                    }
                    if (i == 2)
                    {
  lbl_muayene_2ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod2.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_2ilac.Visible = true;
                lbl_ilacbarkod2.Visible = true;
                    }
                    if (i == 3)
                    {
 lbl_muayene_3ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod3.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_3ilac.Visible = true;
                lbl_ilacbarkod3.Visible = true;
                    }
                  
                   
                
               
                        
                    
                }
                else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 4)
                {

                
                if (i == 1)
                {
                    lbl_muayene_1ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod1.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_1ilac.Visible = true;
                    lbl_ilacbarkod1.Visible = true;

                }
                if (i == 2)
                {
                    lbl_muayene_2ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod2.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_2ilac.Visible = true;
                    lbl_ilacbarkod2.Visible = true;
                }
                if (i == 3)
                {
                    lbl_muayene_3ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod3.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_3ilac.Visible = true;
                    lbl_ilacbarkod3.Visible = true;
                }
                if (i == 4)
                {
                    lbl_muayene_4ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod4.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_4ilac.Visible = true;
                    lbl_ilacbarkod4.Visible = true;
                }


            }
                else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 5)
                {

                if (i == 1)
                {
                    lbl_muayene_1ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod1.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_1ilac.Visible = true;
                    lbl_ilacbarkod1.Visible = true;

                }
                if (i == 2)
                {
                    lbl_muayene_2ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod2.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_2ilac.Visible = true;
                    lbl_ilacbarkod2.Visible = true;
                }
                if (i == 3)
                {
                    lbl_muayene_3ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod3.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_3ilac.Visible = true;
                    lbl_ilacbarkod3.Visible = true;
                }
                if (i == 4)
                {
                    lbl_muayene_4ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod4.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_4ilac.Visible = true;
                    lbl_ilacbarkod4.Visible = true;
                }
                if (i == 5)
                {
lbl_muayene_5ilac.Visible = true;
                lbl_ilacbarkod5.Visible = true;
                lbl_muayene_5ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                        lbl_ilacbarkod5.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                }
                
                       
                    
                }
                else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 6)
                {

                if (i == 1)
                {
                    lbl_muayene_1ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod1.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_1ilac.Visible = true;
                    lbl_ilacbarkod1.Visible = true;

                }
                if (i == 2)
                {
                    lbl_muayene_2ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod2.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_2ilac.Visible = true;
                    lbl_ilacbarkod2.Visible = true;
                }
                if (i == 3)
                {
                    lbl_muayene_3ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod3.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_3ilac.Visible = true;
                    lbl_ilacbarkod3.Visible = true;
                }
                if (i == 4)
                {
                    lbl_muayene_4ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod4.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                    lbl_muayene_4ilac.Visible = true;
                    lbl_ilacbarkod4.Visible = true;
                }
                if (i == 5)
                {
                    lbl_muayene_5ilac.Visible = true;
                    lbl_ilacbarkod5.Visible = true;
                    lbl_muayene_5ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                    lbl_ilacbarkod5.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                }
                if (i == 6)
                {
 lbl_muayene_6ilac.Visible = true;
                lbl_ilacbarkod6.Visible = true;
                lbl_muayene_6ilac.Text = dataGridView_ilaclar.CurrentRow.Cells["Ilac_Adi"].Value.ToString();
                        lbl_ilacbarkod6.Text = dataGridView_ilaclar.CurrentRow.Cells["Barkod"].Value.ToString();
                }
               
                        
                    
                }



            i++;
            lbl_ilac_sayac.Text = i.ToString();


        
        }

       

        public void cmbgetir(string sorgu , ComboBox cmb , string sutunadi)
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

        public void lblgetir(string sorgu, Label lbl, string sutunadi)
        {
            //label e veri getirme
            con = new SqlConnection("Server=.;Database=DIS_KLINIGI;Trusted_Connection=True;");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl.Text = dr[sutunadi].ToString();
            }
            else
            {
                lbl.Text = "";
            }
            con.Dispose();
            con.Close();
        }

        private void MUAYENE_EKRANI_Load(object sender, EventArgs e)
        {
            //sayfa geldiğinde combobox ve datagridviewler dolacak
            cmbgetir("SELECT * FROM ISLEMLER",cmb_muayene_islem,"Islem_Adi");
            griddoldur("SELECT r.TC,h.Ad,h.Soyad,r.Randevu_Tarih,r.Randevu_ID FROM RANDEVU r,HASTA_BILGILERI h where r.TC=h.TC and r.ONAY is null ORDER BY Randevu_Tarih","RANDEVU",dataGridView_randevu);
            griddoldur("SELECT Ilac_Adi,Ilac_Kategori,Barkod from ILACLAR","ILACLAR",dataGridView_ilaclar);

        }

        void griddoldur(string sorgu,string tablo,DataGridView dtg)
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

        private void dataGridView_randevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //randevuya tıkladıgımızda hasta bilgileri forma gelsin
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dataGridView_randevu.Rows[e.RowIndex].Selected = true;
                txt_muayene_tc.Text = dataGridView_randevu.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl_muayen_adi.Text = dataGridView_randevu.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbl_muayen_soyadi.Text = dataGridView_randevu.Rows[e.RowIndex].Cells[2].Value.ToString();

                lblrandevu.Text = dataGridView_randevu.Rows[e.RowIndex].Cells[4].Value.ToString();
               

            }
            }

        private void btn_randevulu_muayene_basla_Click(object sender, EventArgs e)
        {
            //muayeneye basla dedigimizde randevu tablosunda onay 1 oluyor ve hasta kabul tablosuna veriler giriliyor
            insertupdatedelete("update RANDEVU set ONAY='1' where Randevu_ID="+lblrandevu.Text);
            insertupdatedelete("insert into HASTA_KABUL (TC,Randevu_ID,Sikayet,Tarih) values (" + txt_muayene_tc.Text + ",'" + lblrandevu.Text + "','" + txt_muayene_sikayet.Text + "','" + dateTimePicker_suan.Text + "')");
            lblgetir("SELECT * FROM HASTA_KABUL WHERE TC=" + txt_muayene_tc.Text + " order by Hasta_Kabul_ID desc", lbl_Hastakabulid, "Hasta_Kabul_ID");
            MessageBox.Show("MUAYENEYE BAŞLANDI...");
            lblgetir("SELECT * FROM HASTA_BILGILERI WHERE TC="+txt_muayene_tc.Text,lbl_kurumid,"Kurum_ID");
        }

        public void insertupdatedelete(string sorgu)
        {
dateTimePicker_suan.Value = DateTime.Now;
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }

       

        private void btn_randevusuz_muayenebasla_Click(object sender, EventArgs e)
        {
            insertupdatedelete("insert into HASTA_KABUL (TC,Sikayet,Tarih) values (" + cmb_muayene_randevusuztc.Text + ",'" + txt_muayene_randvusuzsikayet.Text + "','" + dateTimePicker_suan.Text + "')");
            lblgetir("SELECT * FROM HASTA_KABUL WHERE TC=" + cmb_muayene_randevusuztc.Text+" order by Hasta_Kabul_ID desc", lbl_Hastakabulid, "Hasta_Kabul_ID");
            MessageBox.Show("MUAYENEYE BAŞLANDI...");
            lblgetir("SELECT * FROM HASTA_BILGILERI WHERE TC="+cmb_muayene_randevusuztc.Text, lbl_kurumid, "Kurum_ID");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                cmbgetir("SELECT * FROM HASTA_BILGILERI",cmb_muayene_randevusuztc,"TC");
            
        }

        private void cmb_muayene_randevusuztc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //randevusuz girişte hastanın tc si yazıldıgında bilgileri gelir
            lblgetir("SELECT * FROM HASTA_BILGILERI WHERE TC="+cmb_muayene_randevusuztc.Text,lbl_muayene_randevusuzad,"Ad");
            lblgetir("SELECT * FROM HASTA_BILGILERI WHERE TC="+cmb_muayene_randevusuztc.Text,lbl_muayene_randevusuzsoyad,"Soyad");
        }

       

        private void btn_muayene_islemekle_Click(object sender, EventArgs e)
        {

             insertupdatedelete("insert into HASTALARA_YAPILAN_ISLEMLER (Hasta_Kabul_ID,Islem_Yapilan_Dis) values ('" + lbl_Hastakabulid.Text + "','" + cmb_muayene_cene.Text + "'+' - '+'" + cmb_muayene_dis.Text + "')");
Label qq = new Label();
            lblgetir("SELECT * FROM HASTALARA_YAPILAN_ISLEMLER ORDER BY Yapilan_Islem_ID desc",qq,"Yapilan_Islem_ID");
            insertupdatedelete("update HASTALARA_YAPILAN_ISLEMLER set Islem=i.Islem_ID FROM ISLEMLER i WHERE i.Islem_Adi like '"+cmb_muayene_islem.Text+"' and Yapilan_Islem_ID="+qq.Text);
            griddoldur("SELECT hb.TC,hb.Ad,hb.Soyad,i.Islem_Adi,h.Islem_Yapilan_Dis,h.Yapilan_Islem_ID FROM HASTALARA_YAPILAN_ISLEMLER h,ISLEMLER i,HASTA_KABUL hk,HASTA_BILGILERI hb WHERE h.Islem=Islem_ID and h.Hasta_Kabul_ID=hk.Hasta_Kabul_ID and hk.TC=hb.TC and h.Hasta_Kabul_ID="+lbl_Hastakabulid.Text, "HASTALARA_YAPILAN_ISLEMLER", dataGridView_yapilanislem);
            cmb_muayene_islem.Text = "";
            cmb_muayene_dis.Text = "";
            cmb_muayene_cene.Text = "";
                
        }

        private void btn_muayene_islemkaldir_Click(object sender, EventArgs e)
        {
            insertupdatedelete("delete from HASTALARA_YAPILAN_ISLEMLER where Yapilan_Islem_ID="+lbl_yapilanislemid.Text);
            griddoldur("SELECT hb.TC,hb.Ad,hb.Soyad,i.Islem_Adi,h.Islem_Yapilan_Dis,h.Yapilan_Islem_ID FROM HASTALARA_YAPILAN_ISLEMLER h,ISLEMLER i,HASTA_KABUL hk,HASTA_BILGILERI hb WHERE h.Islem=Islem_ID and h.Hasta_Kabul_ID=hk.Hasta_Kabul_ID and hk.TC=hb.TC and h.Hasta_Kabul_ID=" + lbl_Hastakabulid.Text, "HASTALARA_YAPILAN_ISLEMLER", dataGridView_yapilanislem);
            cmb_muayene_islem.Text = "";
            cmb_muayene_dis.Text = "";
            cmb_muayene_cene.Text = "";
        }

        private void dataGridView_yapilanislem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           cmb_muayene_islem.Text = dataGridView_yapilanislem.Rows[e.RowIndex].Cells[3].Value.ToString();
            string[] dizi = dataGridView_yapilanislem.Rows[e.RowIndex].Cells[4].Value.ToString().Split('-');
            cmb_muayene_dis.Text = dizi[1];
            cmb_muayene_cene.Text = dizi[0];
            lbl_yapilanislemid.Text = dataGridView_yapilanislem.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_ilacturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ilacturu.SelectedIndex == 0)
            {
 griddoldur("SELECT Ilac_Adi,Ilac_Kategori,Barkod from ILACLAR where Ilac_Kategori='Ağrı Kesici'", "ILACLAR", dataGridView_ilaclar);
           
            }
            else if (cmb_ilacturu.SelectedIndex == 1)
            {
                griddoldur("SELECT Ilac_Adi,Ilac_Kategori,Barkod from ILACLAR where Ilac_Kategori='Antibiyotik'", "ILACLAR", dataGridView_ilaclar);
            }

           
        }

        private void numericUpDown_ilacsayi_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 0)
            {
                lbl_muayene_ilac1.Visible = false;
                lbl_muayene_ilac2.Visible = false;
                lbl_muayene_ilac3.Visible = false;
                lbl_muayene_ilac4.Visible = false;
                lbl_muayene_ilac5.Visible = false;
                lbl_muayene_ilac6.Visible = false;
                lbl_muayene_4ilac.Visible = false;
                lbl_muayene_5ilac.Visible = false;
                lbl_muayene_6ilac.Visible = false;
                lbl_muayene_3ilac.Visible = false;
                lbl_muayene_2ilac.Visible = false;
                lbl_muayene_1ilac.Visible = false;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;
            }

            else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 1)
            {
                lbl_muayene_ilac1.Visible = true;
                lbl_muayene_ilac2.Visible = false;
                lbl_muayene_ilac3.Visible = false;
                lbl_muayene_ilac4.Visible = false;
                lbl_muayene_ilac5.Visible = false;
                lbl_muayene_ilac6.Visible = false;
                lbl_muayene_4ilac.Visible = false;
                lbl_muayene_5ilac.Visible = false;
                lbl_muayene_6ilac.Visible = false;
                lbl_muayene_3ilac.Visible = false;
                lbl_muayene_2ilac.Visible = false;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;

            }
           else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 2)
            {
                lbl_muayene_ilac2.Visible = true;
                lbl_muayene_ilac3.Visible = false;
                lbl_muayene_ilac4.Visible = false;
                lbl_muayene_ilac5.Visible = false;
                lbl_muayene_ilac6.Visible = false;
                lbl_muayene_ilac1.Visible = true;
                lbl_muayene_4ilac.Visible = false;
                lbl_muayene_5ilac.Visible = false;
                lbl_muayene_6ilac.Visible = false;
                lbl_muayene_3ilac.Visible = false;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;

            }
            else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 3)
            {
                lbl_muayene_ilac3.Visible = true;
                lbl_muayene_ilac2.Visible = true;
                lbl_muayene_ilac4.Visible = false;
                lbl_muayene_ilac5.Visible = false;
                lbl_muayene_ilac6.Visible = false;
                lbl_muayene_ilac1.Visible = true;
                lbl_muayene_4ilac.Visible = false;
                lbl_muayene_5ilac.Visible = false;
                lbl_muayene_6ilac.Visible = false;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;

            }
            else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 4)
            {
                lbl_muayene_ilac4.Visible = true;
                lbl_muayene_ilac5.Visible = false;
                lbl_muayene_ilac6.Visible = false;
                lbl_muayene_ilac1.Visible = true;
                lbl_muayene_ilac2.Visible = true;
                lbl_muayene_ilac3.Visible = true;
                lbl_muayene_6ilac.Visible = false;
                lbl_muayene_5ilac.Visible = false;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;
            }
            else if (Convert.ToInt32(numericUpDown_ilacsayi.Value) == 5)
            {
                lbl_muayene_ilac4.Visible = true;
                lbl_muayene_ilac5.Visible = true;
                lbl_muayene_ilac6.Visible = false;
                lbl_muayene_ilac1.Visible = true;
                lbl_muayene_ilac2.Visible = true;
                lbl_muayene_ilac3.Visible = true;
                lbl_muayene_6ilac.Visible = false;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;

            }
            else
            {
                lbl_muayene_ilac6.Visible = true;
                lbl_muayene_ilac4.Visible = true;
                lbl_muayene_ilac5.Visible = true;
                lbl_muayene_ilac6.Visible = true;
                lbl_muayene_ilac1.Visible = true;
                lbl_muayene_ilac2.Visible = true;
                lbl_muayene_ilac3.Visible = true;
                lbl_ilacbarkod1.Visible = false;
                lbl_ilacbarkod2.Visible = false;
                lbl_ilacbarkod3.Visible = false;
                lbl_ilacbarkod4.Visible = false;
                lbl_ilacbarkod5.Visible = false;
                lbl_ilacbarkod6.Visible = false;
            }
        }

        private void btn_muayene_recetekaydet_Click(object sender, EventArgs e)
        {
            dateTimePicker_bugun.Value = DateTime.Now;

            if (lbl_muayene_1ilac.Text != "1.Ilac")
            {                            
                insertupdatedelete("insert into RECETELER (Hasta_Kabul_ID,Kurum_ID,Ilac_Barkod,Recete_Tarihi) values (" + lbl_Hastakabulid.Text + ",'" + lbl_kurumid.Text + "','" + lbl_ilacbarkod1.Text + "','" + dateTimePicker_bugun.Text + "')");               
            }
            if (lbl_muayene_2ilac.Text != "2.Ilac")
            {
                insertupdatedelete("insert into RECETELER (Hasta_Kabul_ID,Kurum_ID,Ilac_Barkod,Recete_Tarihi) values (" + lbl_Hastakabulid.Text + ",'" + lbl_kurumid.Text + "','" + lbl_ilacbarkod2.Text + "','" + dateTimePicker_bugun.Text + "')");
             }
            if (lbl_muayene_3ilac.Text != "3.Ilac")
            {
                insertupdatedelete("insert into RECETELER (Hasta_Kabul_ID,Kurum_ID,Ilac_Barkod,Recete_Tarihi) values (" + lbl_Hastakabulid.Text + ",'" + lbl_kurumid.Text + "','" + lbl_ilacbarkod3.Text + "','" + dateTimePicker_bugun.Text + "')");
            }
            if (lbl_muayene_4ilac.Text != "4.Ilac")
            {
                insertupdatedelete("insert into RECETELER (Hasta_Kabul_ID,Kurum_ID,Ilac_Barkod,Recete_Tarihi) values (" + lbl_Hastakabulid.Text + ",'" + lbl_kurumid.Text + "','" + lbl_ilacbarkod4.Text + "','" + dateTimePicker_bugun.Text + "')");

            }
            if (lbl_muayene_5ilac.Text != "5.Ilac")
            {
                insertupdatedelete("insert into RECETELER (Hasta_Kabul_ID,Kurum_ID,Ilac_Barkod,Recete_Tarihi) values (" + lbl_Hastakabulid.Text + ",'" + lbl_kurumid.Text + "','" + lbl_ilacbarkod5.Text + "','" + dateTimePicker_bugun.Text + "')");
            }
            if (lbl_muayene_6ilac.Text != "6.Ilac")
            {
                insertupdatedelete("insert into RECETELER (Hasta_Kabul_ID,Kurum_ID,Ilac_Barkod,Recete_Tarihi) values (" + lbl_Hastakabulid.Text + ",'" + lbl_kurumid.Text + "','" + lbl_ilacbarkod6.Text + "','" + dateTimePicker_bugun.Text + "')");
            }
            MessageBox.Show("REÇETE KAYDEDILDI...");


        }

        private void btn_muayenebitir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KASA_EKRANI form = new KASA_EKRANI();
            form.Show();
        }
    }
}
