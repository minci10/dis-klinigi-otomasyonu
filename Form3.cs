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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;
        Label lbl = new Label();
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                yenigriddoldur("SELECT * FROM ILCELER WHERE Il_Plaka<>0 ORDER BY Il_Plaka", dataGridView_ilceler);
            }
            if (tabControl1.SelectedIndex == 0)
            {
                yenigriddoldur("SELECT * FROM ILLER WHERE Plaka<>0",dataGridView_iller);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                yenigriddoldur("SELECT * FROM KURUMLAR WHERE Kurum_ID<>20",dataGridView_kurumlar);
            }
            if (tabControl1.SelectedIndex == 3)
            {
                yenigriddoldur("SELECT * FROM ILACLAR",dataGridView_ilaclar);
            }
            if (tabControl1.SelectedIndex == 4)
            {
                yenigriddoldur("select * from ISLEMLER", dataGridView_islemler);
            }
            if (tabControl1.SelectedIndex == 5)
            {
                yenigriddoldur("SELECT * FROM ODEME_TURLERI",dataGridView_odemeturleri);
            }
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




        private void btn_iller_ekle_Click(object sender, EventArgs e)
        {
            cmbuilderinsert("SELECT * FROM ILLER WHERE Plaka<>0", dataGridView_iller);
           

        }

        private void btn_iller_sil_Click(object sender, EventArgs e)
        {
            insertupdatedelete("delete from ILLER where Plaka like '"+lbl.Text+"'");
            
            yenigriddoldur("SELECT * FROM ILLER WHERE Plaka<>0", dataGridView_iller);
       MessageBox.Show("SILME ISLEMI BASARILI...");
        }

        private void btn_iller_guncelle_Click(object sender, EventArgs e)
        {
            cmbuilderguncelle("SELECT * FROM ILLER WHERE Plaka<>0", dataGridView_iller);
            
            
        }

        private void dataGridView_iller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl.Text = dataGridView_iller.Rows[e.RowIndex].Cells[0].Value.ToString();
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            yenigriddoldur("SELECT * FROM ILLER WHERE Plaka<>0", dataGridView_iller);
        }

        private void btn_kurumlar_ekle_Click(object sender, EventArgs e)
        {
            cmbuilderinsert("SELECT * FROM KURUMLAR WHERE Kurum_ID<>20", dataGridView_kurumlar);
       
        }

        private void btn_ilacekle_Click(object sender, EventArgs e)
        {
            cmbuilderinsert("SELECT * FROM ILACLAR", dataGridView_ilaclar);
            
      
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            cmbuilderguncelle("SELECT * FROM ILACLAR", dataGridView_ilaclar);
            lbl.Text = dataGridView_ilaclar.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void btn_ilacsil_Click(object sender, EventArgs e)
        {

            insertupdatedelete("delete from ILACLAR where Barkod like '" + lbl.Text + "'");
            yenigriddoldur("SELECT * FROM ILACLAR", dataGridView_ilaclar);
            MessageBox.Show("SILME ISLEMI BASARILI...");
        }

        private void dataGridView_ilaclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl.Text = dataGridView_ilaclar.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView_kurumlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            lbl.Text = dataGridView_kurumlar.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_odemeturekle_Click(object sender, EventArgs e)
        {
            cmbuilderinsert("SELECT * FROM ODEME_TURLERI", dataGridView_odemeturleri);
            
        }

        private void btn_odemetursil_Click(object sender, EventArgs e)
        {
            insertupdatedelete("delete from ODEME_TURLERI where Odeme_Tur_ID like '"+lbl.Text+"'");
           
            yenigriddoldur("SELECT * FROM ODEME_TURLERI", dataGridView_odemeturleri);
            MessageBox.Show("SILME ISLEMI BASARILI...");


            
        }

        private void dataGridView_odemeturleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl.Text = dataGridView_odemeturleri.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_odemeturguncelle_Click(object sender, EventArgs e)
        {
            cmbuilderguncelle("SELECT * FROM ODEME_TURLERI", dataGridView_odemeturleri);
   

        }

        private void btn_kurumlar_guncelle_Click(object sender, EventArgs e)
        {
            cmbuilderguncelle("SELECT * FROM KURUMLAR WHERE Kurum_ID<>20", dataGridView_kurumlar);
        
        }

        private void btn_kurumlar_sil_Click(object sender, EventArgs e)
        {
           
            insertupdatedelete("delete from KURUMLAR where Kurum_ID like '" + lbl.Text + "'");
            yenigriddoldur("SELECT * FROM KURUMLAR WHERE Kurum_ID<>20", dataGridView_kurumlar);
            MessageBox.Show("SILME ISLEMI BASARILI...");
        }

        private void btn_islemler_islemekle_Click(object sender, EventArgs e)
        {
            cmbuilderinsert("SELECT * FROM ISLEMLER", dataGridView_islemler);
         
        }

        private void btn_islemler_islemguncelle_Click(object sender, EventArgs e)
        {
            cmbuilderguncelle("SELECT * FROM ISLEMLER", dataGridView_islemler);
           
        }

        private void btn_islemler_islemsil_Click(object sender, EventArgs e)
        {

            insertupdatedelete("delete from ISLEMLER where Islem_ID like '" + lbl.Text + "'");
            yenigriddoldur("SELECT * FROM ISLEMLER",dataGridView_islemler);
        MessageBox.Show("SILME ISLEMI BASARILI...");
        }

        private void dataGridView_islemler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl.Text = dataGridView_islemler.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_ilceler_ekle_Click(object sender, EventArgs e)
        {
         
            cmbuilderinsert("SELECT * FROM ILCELER WHERE Il_Plaka<>0 ORDER BY Il_Plaka", dataGridView_ilceler);
        }

        private void btn_ilceler_guncelle_Click(object sender, EventArgs e)
        {
            cmbuilderguncelle("SELECT * FROM ILCELER WHERE Il_Plaka<>0 ORDER BY Il_Plaka", dataGridView_ilceler);
        }

        private void btn_ilceler_sil_Click(object sender, EventArgs e)
        {
            insertupdatedelete("delete from ILCELER where Ilce_ID like '" + lbl.Text + "'");
            yenigriddoldur("SELECT * FROM ILCELER WHERE Il_Plaka<>0 ORDER BY Il_Plaka", dataGridView_ilceler);
            MessageBox.Show("SILME ISLEMI BASARILI...");
        }

        private void dataGridView_ilceler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl.Text = dataGridView_ilceler.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

      
  
        

       
        public void yenigriddoldur (string sorgu,DataGridView dtg){
            con = new SqlConnection("server = MUHAMMET; Initial Catalog = DIS_KLINIGI; Integrated Security = SSPI");
            cmd = new SqlCommand(sorgu, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dtg.DataSource = dt;
        }

        public void cmbuilderinsert(string ww,DataGridView qq)
        {
            SqlCommandBuilder asd = new SqlCommandBuilder(da);
            asd.GetInsertCommand();
            da.Update(dt);
            yenigriddoldur(ww, qq);
            MessageBox.Show("EKLEME ISLEMI BASARILI...");
        }
        public void cmbuilderguncelle(string aa,DataGridView ss)
        {
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            cmdBuilder.GetUpdateCommand();
            da.Update(dt);
            yenigriddoldur(aa, ss);
            MessageBox.Show("GUNCELLEME ISLEMI BASARILI...");
        }

       
    }
}
