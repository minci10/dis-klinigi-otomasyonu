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
    public partial class HASTA_BILGI : Form
    {
        public HASTA_BILGI()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        Label lbl_cinsiyet = new Label();
        Label lbl_ilktc = new Label();

        
        private void Form1_Load(object sender, EventArgs e)
        {   //form açılınca veritabanından kurumlar iller ilceler comboboxlara dolacak ve gridview dolacak
            try
            {
 cmbgetir("SELECT * FROM KURUMLAR where Kurum_Adi<>'Varsayılan'",cmb_hastabilgi_kurum, "Kurum_Adi");
            cmbgetir("SELECT * FROM ILLER where Plaka<>0",cmb_hastabilgi_yasadigiil,"Il_Adi");
           
            cmbgetir("SELECT * FROM ILCELER where Ilce_ID<>0", cmb_hastabilgi_dogumyeri, "Ilce_Adi");
                 griddoldur("HASTA_BILGILERI", "SELECT h.TC,h.Ad,h.Soyad,h.Baba_Adi,h.Anne_Adi,h.Cinsiyet,h.Dogum_Tarihi,ilc.Ilce_Adi as Dogum_Yeri,h.Medeni_Hali,h.Kan_Grubu,h.Adres,ic.Ilce_Adi as Yasadigi_Ilce,i.Il_Adi as Yasadigi_Il,h.Ev_Tel,h.Cep_Tel,h.Is_Tel,k.Kurum_Adi FROM HASTA_BILGILERI h,ILLER i,ILCELER ic,ILCELER ilc,KURUMLAR k where h.Yasadigi_Il_ID=i.Plaka and h.Kurum_ID=k.Kurum_ID and h.Yasadigi_Ilce_ID=ic.Ilce_ID and ilc.Ilce_ID=h.Dogum_Yeri");

            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }          
        }

       
       

        private void btn_hastabilgiler_HastaEkle_Click(object sender, EventArgs e)
        {
            
            if (rdb_hastabilgi_cinsiyetkadin.Checked)
            {
                lbl_cinsiyet.Text = rdb_hastabilgi_cinsiyetkadin.Text;
            }
            else if (rdb_hastabilgi_cinsiyeterkek.Checked)
            {
                lbl_cinsiyet.Text = rdb_hastabilgi_cinsiyeterkek.Text;
            }


            
          

 updatedelete("insert into HASTA_BILGILERI (TC,Ad,Soyad,Baba_Adi,Anne_Adi,Cinsiyet,Dogum_Tarihi,Medeni_Hali,Kan_Grubu,Adres,Ev_Tel,Cep_Tel,Is_Tel) values (" + txt_hastabilgi_tc.Text + ",'" + txt_hastabilgi_Adi.Text + "','" + txt_hastabilgi_Soyadi.Text + "','" + txt_hastabilgi_BabaAdi.Text + "','" + txt_hastabilgi_AnneAdi.Text + "','" + lbl_cinsiyet.Text + "','" + dateTimePicker_hastabilgi_dogumtarihi.Text + "','" + cmb_hastabilgi_medenihali.SelectedItem.ToString() + "','" + cmb_hastabilgi_kangrubu.Text + " " + cmb_hastabilgi_kangruburh.Text + "','" + txt_hastabilgi_adres.Text + "','" + txt_hastabilgi_evtel.Text + "','" + txt_hastabilgi_ceptel.Text + "','" + txt_hastabilgi_istel.Text + "')");
             updatedelete("update HASTA_BILGILERI set Dogum_Yeri=i.Ilce_ID FROM ILCELER i WHERE i.Ilce_Adi like '" + cmb_hastabilgi_dogumyeri.Text + "' and TC like '" + txt_hastabilgi_tc.Text + "'");
            updatedelete("update HASTA_BILGILERI set Yasadigi_Ilce_ID=i.Ilce_ID FROM ILCELER i WHERE i.Ilce_Adi like '" + cmb_hastabilgi_yasadigiilce.Text + "' and TC like '" + txt_hastabilgi_tc.Text + "'");
            updatedelete("update HASTA_BILGILERI set Yasadigi_Il_ID=il.Plaka FROM ILLER il WHERE il.Il_Adi like '" + cmb_hastabilgi_yasadigiil.Text + "' and TC like '" + txt_hastabilgi_tc.Text + "'");
            updatedelete("update HASTA_BILGILERI set Kurum_ID=k.Kurum_ID FROM KURUMLAR k WHERE k.Kurum_Adi like '" + cmb_hastabilgi_kurum.Text + "' and TC like '" + txt_hastabilgi_tc.Text + "'");
              MessageBox.Show("HASTA EKLENDI");
                griddoldur("HASTA_BILGILERI", "SELECT h.TC,h.Ad,h.Soyad,h.Baba_Adi,h.Anne_Adi,h.Cinsiyet,h.Dogum_Tarihi,ilc.Ilce_Adi as Dogum_Yeri,h.Medeni_Hali,h.Kan_Grubu,h.Adres,ic.Ilce_Adi as Yasadigi_Ilce,i.Il_Adi as Yasadigi_Il,h.Ev_Tel,h.Cep_Tel,h.Is_Tel,k.Kurum_Adi FROM HASTA_BILGILERI h,ILLER i,ILCELER ic,ILCELER ilc,KURUMLAR k where h.Yasadigi_Il_ID=i.Plaka and h.Kurum_ID=k.Kurum_ID and h.Yasadigi_Ilce_ID=ic.Ilce_ID and ilc.Ilce_ID=h.Dogum_Yeri");
                clear();

          

          
        }

      

        
        public void cmbgetir(string sorgu, ComboBox cmb,string kolonadi) {
            
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
              cmb.Items.Add(dr[kolonadi]);
            }
            baglanti.Close();
        }

        private void btn_hastabilgi_hastasil_Click(object sender, EventArgs e)
        {//Hasta Sil
            updatedelete("DELETE FROM HASTA_BILGILERI WHERE TC='" + txt_hastabilgi_tc.Text + "'");
            MessageBox.Show("HASTA BILGILERI SILINDI");
            griddoldur("HASTA_BILGILERI", "SELECT h.TC,h.Ad,h.Soyad,h.Baba_Adi,h.Anne_Adi,h.Cinsiyet,h.Dogum_Tarihi,ilc.Ilce_Adi as Dogum_Yeri,h.Medeni_Hali,h.Kan_Grubu,h.Adres,ic.Ilce_Adi as Yasadigi_Ilce,i.Il_Adi as Yasadigi_Il,h.Ev_Tel,h.Cep_Tel,h.Is_Tel,k.Kurum_Adi FROM HASTA_BILGILERI h,ILLER i,ILCELER ic,ILCELER ilc,KURUMLAR k where h.Yasadigi_Il_ID=i.Plaka and h.Kurum_ID=k.Kurum_ID and h.Yasadigi_Ilce_ID=ic.Ilce_ID and ilc.Ilce_ID=h.Dogum_Yeri");
            clear();
        }
        

        private void cmb_hastabilgi_yasadigiil_SelectedIndexChanged(object sender, EventArgs e)
        {//Yasadigi il secildiginde ilceler yasadigi ilin ilceleri olarak filtrelenecek
            cmb_hastabilgi_yasadigiilce.Text = "";
            cmb_hastabilgi_yasadigiilce.Items.Clear();
          
                cmbgetir("SELECT * FROM ILCELER i,Iller il WHERE i.Il_Plaka=il.Plaka and il.Il_Adi like '"+cmb_hastabilgi_yasadigiil.Text+"'", cmb_hastabilgi_yasadigiilce, "Ilce_Adi");
               
          
           
        }

         private void cmb_hastabilgi_yasadigiilce_SelectedIndexChanged(object sender, EventArgs e)
         {//ilceler combobox unda sadece belli bir ilin ilceleri kaldıgı için ilçenin id sini dogumyerinden referans alıyorum
            comboBox1.Items.Clear();
            string ilceadi = cmb_hastabilgi_yasadigiilce.SelectedItem.ToString();
             try
             {
 cmbgetir("SELECT * FROM ILCELER where Ilce_Adi='" + cmb_hastabilgi_yasadigiilce.Text + "'", comboBox1, "Ilce_ID");
                
             }
             catch (Exception)
             {

                 throw;
             }
           


         }

        void griddoldur(string tablo,string sorgu)
        {
            con = new SqlConnection("server=.; Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI");
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, tablo);
            dataGridView_hastalar.DataSource = ds.Tables[tablo];
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//hasta bilgisi degistirilmek istendiğinde alanların dolması
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dataGridView_hastalar.Rows[e.RowIndex].Selected = true;
                txt_hastabilgi_tc.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_hastabilgi_Adi.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_hastabilgi_Soyadi.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
                {
                    txt_hastabilgi_BabaAdi.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[4].Value.ToString() != "")
                {
                    txt_hastabilgi_AnneAdi.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[5].Value.ToString() != "")
                {
                    if (dataGridView_hastalar.Rows[e.RowIndex].Cells[5].Value.ToString() == "Erkek")
                {
                    rdb_hastabilgi_cinsiyeterkek.Checked = true;
                }
                else if (dataGridView_hastalar.Rows[e.RowIndex].Cells[5].Value.ToString() == "Kadın")
                {
                    rdb_hastabilgi_cinsiyetkadin.Checked = true;

                }
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[6].Value.ToString() != "")
                {
                     dateTimePicker_hastabilgi_dogumtarihi.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[6].Value.ToString();
                }

               

                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[7].Value.ToString() != "")
                {
    cmb_hastabilgi_dogumyeri.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[8].Value.ToString() != "")
                {
 cmb_hastabilgi_medenihali.SelectedItem = dataGridView_hastalar.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[10].Value.ToString() != "")
                {
 txt_hastabilgi_adres.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[10].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[12].Value.ToString() != "")
                {
                    cmb_hastabilgi_yasadigiil.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[12].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[11].Value.ToString() != "")
                {
                    cmb_hastabilgi_yasadigiilce.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[11].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[13].Value.ToString() != "")
                {
 txt_hastabilgi_evtel.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[13].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[14].Value.ToString() != "")
                {
                    txt_hastabilgi_ceptel.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[14].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[15].Value.ToString() != "")
                {
                    txt_hastabilgi_istel.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[15].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[16].Value.ToString() != "")
                {
                    cmb_hastabilgi_kurum.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[16].Value.ToString();
                }
                if (dataGridView_hastalar.Rows[e.RowIndex].Cells[9].Value.ToString() != "")
                {
                    string kangrubu = dataGridView_hastalar.Rows[e.RowIndex].Cells[9].Value.ToString();
                    if (kangrubu.EndsWith("-") == true)
                    {
                        cmb_hastabilgi_kangruburh.SelectedIndex = 1;
                    }

                    else if (kangrubu.EndsWith("-") == false)
                    {
                        cmb_hastabilgi_kangruburh.SelectedIndex = 0;
                    }
                    if (kangrubu.StartsWith("0") == true)
                    {
                        cmb_hastabilgi_kangrubu.SelectedIndex = 3;
                    }
                    else if (kangrubu.StartsWith("B") == true)
                    {
                        cmb_hastabilgi_kangrubu.SelectedIndex = 1;
                    }
                    else if (kangrubu.StartsWith("AB") == true)
                    {
                        cmb_hastabilgi_kangrubu.SelectedIndex = 2;
                    }
                    else
                    {
                        cmb_hastabilgi_kangrubu.SelectedIndex = 0;
                    }
                }


                lbl_ilktc.Text = dataGridView_hastalar.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_hastabilgileri_HastaGuncelle_Click(object sender, EventArgs e)
        {
            try
            { if (rdb_hastabilgi_cinsiyetkadin.Checked)
            {lbl_cinsiyet.Text = rdb_hastabilgi_cinsiyetkadin.Text; }
            else if (rdb_hastabilgi_cinsiyeterkek.Checked)
            {lbl_cinsiyet.Text = rdb_hastabilgi_cinsiyeterkek.Text;}


        updatedelete("UPDATE HASTA_BILGILERI SET TC='" + txt_hastabilgi_tc.Text + "',Ad='" + txt_hastabilgi_Adi.Text + "',Soyad='" + txt_hastabilgi_Soyadi.Text + "',Baba_Adi='" + txt_hastabilgi_BabaAdi.Text + "',Anne_Adi='" + txt_hastabilgi_AnneAdi.Text + "',Cinsiyet='" + lbl_cinsiyet.Text + "',Dogum_Tarihi='" + dateTimePicker_hastabilgi_dogumtarihi.Text + "',Dogum_Yeri=ic.Ilce_ID,Medeni_Hali='" + cmb_hastabilgi_medenihali.SelectedItem.ToString() + "',Kan_Grubu='" + cmb_hastabilgi_kangrubu.Text + " " + cmb_hastabilgi_kangruburh.Text + "',Adres='" + txt_hastabilgi_adres.Text + "',Yasadigi_Ilce_ID=ilc.Ilce_ID,Yasadigi_Il_ID=il.Plaka,Ev_Tel='" + txt_hastabilgi_evtel.Text + "',Cep_Tel='" + txt_hastabilgi_ceptel.Text + "',Is_Tel='" + txt_hastabilgi_istel.Text + "',Kurum_ID=k.Kurum_ID FROM HASTA_BILGILERI hk,ILLER il,ILCELER ic,ILCELER ilc,KURUMLAR k where il.Il_Adi like '"+cmb_hastabilgi_yasadigiil.Text+"' and k.Kurum_Adi like '"+cmb_hastabilgi_kurum.Text+"' and ic.Ilce_Adi like '"+cmb_hastabilgi_dogumyeri.Text+"' and ilc.Ilce_Adi like '"+cmb_hastabilgi_yasadigiilce.Text+ "' and hk.TC like '"+lbl_ilktc.Text+"'");

                griddoldur("HASTA_BILGILERI", "SELECT h.TC,h.Ad,h.Soyad,h.Baba_Adi,h.Anne_Adi,h.Cinsiyet,h.Dogum_Tarihi,ilc.Ilce_Adi as Dogum_Yeri,h.Medeni_Hali,h.Kan_Grubu,h.Adres,ic.Ilce_Adi as Yasadigi_Ilce,i.Il_Adi as Yasadigi_Il,h.Ev_Tel,h.Cep_Tel,h.Is_Tel,k.Kurum_Adi FROM HASTA_BILGILERI h,ILLER i,ILCELER ic,ILCELER ilc,KURUMLAR k where h.Yasadigi_Il_ID=i.Plaka and h.Kurum_ID=k.Kurum_ID and h.Yasadigi_Ilce_ID=ic.Ilce_ID and ilc.Ilce_ID=h.Dogum_Yeri");
                clear();
                MessageBox.Show("KAYIT GUNCELLEME BASARILI...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


                throw;
            }
        }





        








        public void clear()
        {
            txt_hastabilgi_tc.Text = "";
            txt_hastabilgi_Adi.Text = "";
txt_hastabilgi_adres.Text = "";
txt_hastabilgi_AnneAdi.Text = "";
txt_hastabilgi_BabaAdi.Text = "";
txt_hastabilgi_ceptel.Text = "";
txt_hastabilgi_evtel.Text = "";
txt_hastabilgi_istel.Text = "";
txt_hastabilgi_Soyadi.Text = "";
            rdb_hastabilgi_cinsiyeterkek.Checked = false;
            rdb_hastabilgi_cinsiyetkadin.Checked = false;
            cmb_hastabilgi_dogumyeri.SelectedIndex = -1;
            cmb_hastabilgi_kangrubu.SelectedIndex = -1;
cmb_hastabilgi_kangruburh.SelectedIndex = -1;
cmb_hastabilgi_kurum.SelectedIndex = -1;
cmb_hastabilgi_medenihali.SelectedIndex = -1;
cmb_hastabilgi_yasadigiil.SelectedIndex = -1;
cmb_hastabilgi_yasadigiilce.SelectedIndex = -1;


        }

        public void updatedelete(string sorgu){
            try
            {
 con = new SqlConnection();
        con.ConnectionString = "Data Source=.;Initial Catalog=DIS_KLINIGI;Integrated Security=SSPI";
            cmd = new SqlCommand();
        con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();}
 catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }    
            }
               
        private void txt_hastabilgi_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_hastabilgi_evtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_hastabilgi_ceptel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_hastabilgi_istel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_hastabilgi_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_hastabilgi_Soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_hastabilgi_AnneAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_hastabilgi_BabaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
    }

