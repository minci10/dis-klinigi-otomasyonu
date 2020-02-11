namespace WindowsFormsApplication5
{
    partial class KASA_EKRANI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KASA_EKRANI));
            this.datagridview_kasa = new System.Windows.Forms.DataGridView();
            this.tabControl1_kasaekrani = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kasaekrani_gelirtutar = new System.Windows.Forms.TextBox();
            this.lbl_kasaekrani_gelirtutar = new System.Windows.Forms.Label();
            this.btn_gelir = new System.Windows.Forms.Button();
            this.lbl_kasaekrani_odemeturu = new System.Windows.Forms.Label();
            this.cmb_kasaekrani_odemeturu = new System.Windows.Forms.ComboBox();
            this.lbl_hastakabulid = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_kasaekrani_giderekle = new System.Windows.Forms.Button();
            this.txt_kasaekrani_gideraciklama = new System.Windows.Forms.TextBox();
            this.txt_kasaekrani_gidertutar = new System.Windows.Forms.TextBox();
            this.lbl_kasaekrani_gideraciklama = new System.Windows.Forms.Label();
            this.lbl_kasaekrani_gidertutar = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_kasa)).BeginInit();
            this.tabControl1_kasaekrani.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview_kasa
            // 
            this.datagridview_kasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_kasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridview_kasa.Location = new System.Drawing.Point(0, 0);
            this.datagridview_kasa.Name = "datagridview_kasa";
            this.datagridview_kasa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridview_kasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_kasa.Size = new System.Drawing.Size(546, 248);
            this.datagridview_kasa.TabIndex = 0;
            this.datagridview_kasa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_kasa_CellClick);
            // 
            // tabControl1_kasaekrani
            // 
            this.tabControl1_kasaekrani.Controls.Add(this.tabPage1);
            this.tabControl1_kasaekrani.Controls.Add(this.tabPage2);
            this.tabControl1_kasaekrani.Controls.Add(this.tabPage3);
            this.tabControl1_kasaekrani.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1_kasaekrani.Location = new System.Drawing.Point(0, 254);
            this.tabControl1_kasaekrani.Name = "tabControl1_kasaekrani";
            this.tabControl1_kasaekrani.SelectedIndex = 0;
            this.tabControl1_kasaekrani.Size = new System.Drawing.Size(546, 232);
            this.tabControl1_kasaekrani.TabIndex = 1;
            this.tabControl1_kasaekrani.SelectedIndexChanged += new System.EventHandler(this.tabControl1_kasaekrani_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.txt_aciklama);
            this.tabPage1.Controls.Add(this.lbl_aciklama);
            this.tabPage1.Controls.Add(this.txt_tc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_kasaekrani_gelirtutar);
            this.tabPage1.Controls.Add(this.lbl_kasaekrani_gelirtutar);
            this.tabPage1.Controls.Add(this.btn_gelir);
            this.tabPage1.Controls.Add(this.lbl_kasaekrani_odemeturu);
            this.tabPage1.Controls.Add(this.cmb_kasaekrani_odemeturu);
            this.tabPage1.Controls.Add(this.lbl_hastakabulid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GELİR";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(99, 150);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_aciklama.Size = new System.Drawing.Size(121, 48);
            this.txt_aciklama.TabIndex = 3;
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_aciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_aciklama.Location = new System.Drawing.Point(9, 153);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(65, 13);
            this.lbl_aciklama.TabIndex = 11;
            this.lbl_aciklama.Text = "Açıklama :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(99, 12);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(121, 20);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.TextChanged += new System.EventHandler(this.txt_tc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC :";
            // 
            // txt_kasaekrani_gelirtutar
            // 
            this.txt_kasaekrani_gelirtutar.Location = new System.Drawing.Point(99, 107);
            this.txt_kasaekrani_gelirtutar.Name = "txt_kasaekrani_gelirtutar";
            this.txt_kasaekrani_gelirtutar.Size = new System.Drawing.Size(100, 20);
            this.txt_kasaekrani_gelirtutar.TabIndex = 2;
            this.txt_kasaekrani_gelirtutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kasaekrani_gelirtutar_KeyPress);
            // 
            // lbl_kasaekrani_gelirtutar
            // 
            this.lbl_kasaekrani_gelirtutar.AutoSize = true;
            this.lbl_kasaekrani_gelirtutar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_kasaekrani_gelirtutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_kasaekrani_gelirtutar.Location = new System.Drawing.Point(9, 111);
            this.lbl_kasaekrani_gelirtutar.Name = "lbl_kasaekrani_gelirtutar";
            this.lbl_kasaekrani_gelirtutar.Size = new System.Drawing.Size(44, 13);
            this.lbl_kasaekrani_gelirtutar.TabIndex = 5;
            this.lbl_kasaekrani_gelirtutar.Text = "Tutar :";
            // 
            // btn_gelir
            // 
            this.btn_gelir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gelir.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_gelir.Location = new System.Drawing.Point(300, 64);
            this.btn_gelir.Name = "btn_gelir";
            this.btn_gelir.Size = new System.Drawing.Size(163, 77);
            this.btn_gelir.TabIndex = 4;
            this.btn_gelir.Text = "KAYIT GIR";
            this.btn_gelir.UseVisualStyleBackColor = true;
            this.btn_gelir.Click += new System.EventHandler(this.btn_gelir_Click);
            // 
            // lbl_kasaekrani_odemeturu
            // 
            this.lbl_kasaekrani_odemeturu.AutoSize = true;
            this.lbl_kasaekrani_odemeturu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_kasaekrani_odemeturu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_kasaekrani_odemeturu.Location = new System.Drawing.Point(9, 64);
            this.lbl_kasaekrani_odemeturu.Name = "lbl_kasaekrani_odemeturu";
            this.lbl_kasaekrani_odemeturu.Size = new System.Drawing.Size(82, 13);
            this.lbl_kasaekrani_odemeturu.TabIndex = 1;
            this.lbl_kasaekrani_odemeturu.Text = "Odeme Türü :";
            // 
            // cmb_kasaekrani_odemeturu
            // 
            this.cmb_kasaekrani_odemeturu.FormattingEnabled = true;
            this.cmb_kasaekrani_odemeturu.Location = new System.Drawing.Point(99, 60);
            this.cmb_kasaekrani_odemeturu.Name = "cmb_kasaekrani_odemeturu";
            this.cmb_kasaekrani_odemeturu.Size = new System.Drawing.Size(121, 21);
            this.cmb_kasaekrani_odemeturu.TabIndex = 1;
            // 
            // lbl_hastakabulid
            // 
            this.lbl_hastakabulid.AutoSize = true;
            this.lbl_hastakabulid.Location = new System.Drawing.Point(130, 167);
            this.lbl_hastakabulid.Name = "lbl_hastakabulid";
            this.lbl_hastakabulid.Size = new System.Drawing.Size(35, 13);
            this.lbl_hastakabulid.TabIndex = 13;
            this.lbl_hastakabulid.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.btn_kasaekrani_giderekle);
            this.tabPage2.Controls.Add(this.txt_kasaekrani_gideraciklama);
            this.tabPage2.Controls.Add(this.txt_kasaekrani_gidertutar);
            this.tabPage2.Controls.Add(this.lbl_kasaekrani_gideraciklama);
            this.tabPage2.Controls.Add(this.lbl_kasaekrani_gidertutar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GİDER";
            // 
            // btn_kasaekrani_giderekle
            // 
            this.btn_kasaekrani_giderekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kasaekrani_giderekle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_kasaekrani_giderekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kasaekrani_giderekle.Location = new System.Drawing.Point(337, 66);
            this.btn_kasaekrani_giderekle.Name = "btn_kasaekrani_giderekle";
            this.btn_kasaekrani_giderekle.Size = new System.Drawing.Size(177, 78);
            this.btn_kasaekrani_giderekle.TabIndex = 7;
            this.btn_kasaekrani_giderekle.Text = "KAYIT GIR";
            this.btn_kasaekrani_giderekle.UseVisualStyleBackColor = true;
            this.btn_kasaekrani_giderekle.Click += new System.EventHandler(this.btn_kasaekrani_giderekle_Click);
            // 
            // txt_kasaekrani_gideraciklama
            // 
            this.txt_kasaekrani_gideraciklama.Location = new System.Drawing.Point(96, 101);
            this.txt_kasaekrani_gideraciklama.Multiline = true;
            this.txt_kasaekrani_gideraciklama.Name = "txt_kasaekrani_gideraciklama";
            this.txt_kasaekrani_gideraciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_kasaekrani_gideraciklama.Size = new System.Drawing.Size(206, 83);
            this.txt_kasaekrani_gideraciklama.TabIndex = 6;
            // 
            // txt_kasaekrani_gidertutar
            // 
            this.txt_kasaekrani_gidertutar.Location = new System.Drawing.Point(99, 36);
            this.txt_kasaekrani_gidertutar.Name = "txt_kasaekrani_gidertutar";
            this.txt_kasaekrani_gidertutar.Size = new System.Drawing.Size(100, 20);
            this.txt_kasaekrani_gidertutar.TabIndex = 5;
            // 
            // lbl_kasaekrani_gideraciklama
            // 
            this.lbl_kasaekrani_gideraciklama.AutoSize = true;
            this.lbl_kasaekrani_gideraciklama.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_kasaekrani_gideraciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_kasaekrani_gideraciklama.Location = new System.Drawing.Point(12, 101);
            this.lbl_kasaekrani_gideraciklama.Name = "lbl_kasaekrani_gideraciklama";
            this.lbl_kasaekrani_gideraciklama.Size = new System.Drawing.Size(65, 13);
            this.lbl_kasaekrani_gideraciklama.TabIndex = 2;
            this.lbl_kasaekrani_gideraciklama.Text = "Açıklama :";
            // 
            // lbl_kasaekrani_gidertutar
            // 
            this.lbl_kasaekrani_gidertutar.AutoSize = true;
            this.lbl_kasaekrani_gidertutar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_kasaekrani_gidertutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_kasaekrani_gidertutar.Location = new System.Drawing.Point(12, 39);
            this.lbl_kasaekrani_gidertutar.Name = "lbl_kasaekrani_gidertutar";
            this.lbl_kasaekrani_gidertutar.Size = new System.Drawing.Size(77, 13);
            this.lbl_kasaekrani_gidertutar.TabIndex = 1;
            this.lbl_kasaekrani_gidertutar.Text = "Gider Tutar :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(538, 206);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SON İŞLEMLER";
            // 
            // KASA_EKRANI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(546, 486);
            this.Controls.Add(this.tabControl1_kasaekrani);
            this.Controls.Add(this.datagridview_kasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KASA_EKRANI";
            this.Text = "KASA_EKRANI";
            this.Load += new System.EventHandler(this.KASA_EKRANI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_kasa)).EndInit();
            this.tabControl1_kasaekrani.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_kasa;
        private System.Windows.Forms.TabControl tabControl1_kasaekrani;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_kasaekrani_gelirtutar;
        private System.Windows.Forms.Label lbl_kasaekrani_gelirtutar;
        private System.Windows.Forms.Button btn_gelir;
        private System.Windows.Forms.Label lbl_kasaekrani_odemeturu;
        private System.Windows.Forms.ComboBox cmb_kasaekrani_odemeturu;
        private System.Windows.Forms.TextBox txt_kasaekrani_gideraciklama;
        private System.Windows.Forms.TextBox txt_kasaekrani_gidertutar;
        private System.Windows.Forms.Label lbl_kasaekrani_gideraciklama;
        private System.Windows.Forms.Label lbl_kasaekrani_gidertutar;
        private System.Windows.Forms.Button btn_kasaekrani_giderekle;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label lbl_aciklama;
        private System.Windows.Forms.Label lbl_hastakabulid;
        private System.Windows.Forms.TabPage tabPage3;
    }
}