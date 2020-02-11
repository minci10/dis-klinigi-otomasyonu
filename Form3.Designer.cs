namespace WindowsFormsApplication5
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_iller = new System.Windows.Forms.TabPage();
            this.btn_iller_sil = new System.Windows.Forms.Button();
            this.btn_iller_guncelle = new System.Windows.Forms.Button();
            this.btn_iller_ekle = new System.Windows.Forms.Button();
            this.dataGridView_iller = new System.Windows.Forms.DataGridView();
            this.tabPage_ilceler = new System.Windows.Forms.TabPage();
            this.btn_ilceler_sil = new System.Windows.Forms.Button();
            this.btn_ilceler_guncelle = new System.Windows.Forms.Button();
            this.btn_ilceler_ekle = new System.Windows.Forms.Button();
            this.dataGridView_ilceler = new System.Windows.Forms.DataGridView();
            this.tabPage_kurumlar = new System.Windows.Forms.TabPage();
            this.btn_kurumlar_sil = new System.Windows.Forms.Button();
            this.btn_kurumlar_guncelle = new System.Windows.Forms.Button();
            this.btn_kurumlar_ekle = new System.Windows.Forms.Button();
            this.dataGridView_kurumlar = new System.Windows.Forms.DataGridView();
            this.tabPage_ilaclar = new System.Windows.Forms.TabPage();
            this.btn_ilacsil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ilacekle = new System.Windows.Forms.Button();
            this.dataGridView_ilaclar = new System.Windows.Forms.DataGridView();
            this.tabPage_islemler = new System.Windows.Forms.TabPage();
            this.btn_islemler_islemsil = new System.Windows.Forms.Button();
            this.btn_islemler_islemguncelle = new System.Windows.Forms.Button();
            this.btn_islemler_islemekle = new System.Windows.Forms.Button();
            this.dataGridView_islemler = new System.Windows.Forms.DataGridView();
            this.tabPage_odemeturleri = new System.Windows.Forms.TabPage();
            this.btn_odemetursil = new System.Windows.Forms.Button();
            this.btn_odemeturguncelle = new System.Windows.Forms.Button();
            this.btn_odemeturekle = new System.Windows.Forms.Button();
            this.dataGridView_odemeturleri = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage_iller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_iller)).BeginInit();
            this.tabPage_ilceler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilceler)).BeginInit();
            this.tabPage_kurumlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kurumlar)).BeginInit();
            this.tabPage_ilaclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilaclar)).BeginInit();
            this.tabPage_islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_islemler)).BeginInit();
            this.tabPage_odemeturleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_odemeturleri)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_iller);
            this.tabControl1.Controls.Add(this.tabPage_ilceler);
            this.tabControl1.Controls.Add(this.tabPage_kurumlar);
            this.tabControl1.Controls.Add(this.tabPage_ilaclar);
            this.tabControl1.Controls.Add(this.tabPage_islemler);
            this.tabControl1.Controls.Add(this.tabPage_odemeturleri);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 474);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_iller
            // 
            this.tabPage_iller.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage_iller.Controls.Add(this.btn_iller_sil);
            this.tabPage_iller.Controls.Add(this.btn_iller_guncelle);
            this.tabPage_iller.Controls.Add(this.btn_iller_ekle);
            this.tabPage_iller.Controls.Add(this.dataGridView_iller);
            this.tabPage_iller.Location = new System.Drawing.Point(4, 22);
            this.tabPage_iller.Name = "tabPage_iller";
            this.tabPage_iller.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_iller.Size = new System.Drawing.Size(430, 448);
            this.tabPage_iller.TabIndex = 0;
            this.tabPage_iller.Text = "ILLER";
            // 
            // btn_iller_sil
            // 
            this.btn_iller_sil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_iller_sil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_iller_sil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iller_sil.Location = new System.Drawing.Point(3, 310);
            this.btn_iller_sil.Name = "btn_iller_sil";
            this.btn_iller_sil.Size = new System.Drawing.Size(424, 45);
            this.btn_iller_sil.TabIndex = 0;
            this.btn_iller_sil.Text = "SIL";
            this.btn_iller_sil.UseVisualStyleBackColor = true;
            this.btn_iller_sil.Click += new System.EventHandler(this.btn_iller_sil_Click);
            // 
            // btn_iller_guncelle
            // 
            this.btn_iller_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_iller_guncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_iller_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iller_guncelle.Location = new System.Drawing.Point(3, 355);
            this.btn_iller_guncelle.Name = "btn_iller_guncelle";
            this.btn_iller_guncelle.Size = new System.Drawing.Size(424, 45);
            this.btn_iller_guncelle.TabIndex = 1;
            this.btn_iller_guncelle.Text = "GUNCELLE";
            this.btn_iller_guncelle.UseVisualStyleBackColor = true;
            this.btn_iller_guncelle.Click += new System.EventHandler(this.btn_iller_guncelle_Click);
            // 
            // btn_iller_ekle
            // 
            this.btn_iller_ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_iller_ekle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_iller_ekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iller_ekle.Location = new System.Drawing.Point(3, 400);
            this.btn_iller_ekle.Name = "btn_iller_ekle";
            this.btn_iller_ekle.Size = new System.Drawing.Size(424, 45);
            this.btn_iller_ekle.TabIndex = 2;
            this.btn_iller_ekle.Text = "EKLE";
            this.btn_iller_ekle.UseVisualStyleBackColor = true;
            this.btn_iller_ekle.Click += new System.EventHandler(this.btn_iller_ekle_Click);
            // 
            // dataGridView_iller
            // 
            this.dataGridView_iller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_iller.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_iller.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_iller.Name = "dataGridView_iller";
            this.dataGridView_iller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_iller.Size = new System.Drawing.Size(424, 306);
            this.dataGridView_iller.TabIndex = 0;
            this.dataGridView_iller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_iller_CellClick);
            // 
            // tabPage_ilceler
            // 
            this.tabPage_ilceler.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage_ilceler.Controls.Add(this.btn_ilceler_sil);
            this.tabPage_ilceler.Controls.Add(this.btn_ilceler_guncelle);
            this.tabPage_ilceler.Controls.Add(this.btn_ilceler_ekle);
            this.tabPage_ilceler.Controls.Add(this.dataGridView_ilceler);
            this.tabPage_ilceler.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ilceler.Name = "tabPage_ilceler";
            this.tabPage_ilceler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ilceler.Size = new System.Drawing.Size(430, 448);
            this.tabPage_ilceler.TabIndex = 1;
            this.tabPage_ilceler.Text = "ILCELER";
            // 
            // btn_ilceler_sil
            // 
            this.btn_ilceler_sil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ilceler_sil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ilceler_sil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ilceler_sil.Location = new System.Drawing.Point(3, 310);
            this.btn_ilceler_sil.Name = "btn_ilceler_sil";
            this.btn_ilceler_sil.Size = new System.Drawing.Size(424, 45);
            this.btn_ilceler_sil.TabIndex = 0;
            this.btn_ilceler_sil.Text = "SIL";
            this.btn_ilceler_sil.UseVisualStyleBackColor = true;
            this.btn_ilceler_sil.Click += new System.EventHandler(this.btn_ilceler_sil_Click);
            // 
            // btn_ilceler_guncelle
            // 
            this.btn_ilceler_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ilceler_guncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ilceler_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ilceler_guncelle.Location = new System.Drawing.Point(3, 355);
            this.btn_ilceler_guncelle.Name = "btn_ilceler_guncelle";
            this.btn_ilceler_guncelle.Size = new System.Drawing.Size(424, 45);
            this.btn_ilceler_guncelle.TabIndex = 1;
            this.btn_ilceler_guncelle.Text = "GUNCELLE";
            this.btn_ilceler_guncelle.UseVisualStyleBackColor = true;
            this.btn_ilceler_guncelle.Click += new System.EventHandler(this.btn_ilceler_guncelle_Click);
            // 
            // btn_ilceler_ekle
            // 
            this.btn_ilceler_ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ilceler_ekle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ilceler_ekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ilceler_ekle.Location = new System.Drawing.Point(3, 400);
            this.btn_ilceler_ekle.Name = "btn_ilceler_ekle";
            this.btn_ilceler_ekle.Size = new System.Drawing.Size(424, 45);
            this.btn_ilceler_ekle.TabIndex = 2;
            this.btn_ilceler_ekle.Text = "EKLE";
            this.btn_ilceler_ekle.UseVisualStyleBackColor = true;
            this.btn_ilceler_ekle.Click += new System.EventHandler(this.btn_ilceler_ekle_Click);
            // 
            // dataGridView_ilceler
            // 
            this.dataGridView_ilceler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ilceler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_ilceler.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_ilceler.Name = "dataGridView_ilceler";
            this.dataGridView_ilceler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ilceler.Size = new System.Drawing.Size(424, 306);
            this.dataGridView_ilceler.TabIndex = 0;
            this.dataGridView_ilceler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ilceler_CellClick);
            // 
            // tabPage_kurumlar
            // 
            this.tabPage_kurumlar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage_kurumlar.Controls.Add(this.btn_kurumlar_sil);
            this.tabPage_kurumlar.Controls.Add(this.btn_kurumlar_guncelle);
            this.tabPage_kurumlar.Controls.Add(this.btn_kurumlar_ekle);
            this.tabPage_kurumlar.Controls.Add(this.dataGridView_kurumlar);
            this.tabPage_kurumlar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_kurumlar.Name = "tabPage_kurumlar";
            this.tabPage_kurumlar.Size = new System.Drawing.Size(430, 448);
            this.tabPage_kurumlar.TabIndex = 2;
            this.tabPage_kurumlar.Text = "KURUMLAR";
            // 
            // btn_kurumlar_sil
            // 
            this.btn_kurumlar_sil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kurumlar_sil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_kurumlar_sil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kurumlar_sil.Location = new System.Drawing.Point(0, 313);
            this.btn_kurumlar_sil.Name = "btn_kurumlar_sil";
            this.btn_kurumlar_sil.Size = new System.Drawing.Size(430, 45);
            this.btn_kurumlar_sil.TabIndex = 0;
            this.btn_kurumlar_sil.Text = "SIL";
            this.btn_kurumlar_sil.UseVisualStyleBackColor = true;
            this.btn_kurumlar_sil.Click += new System.EventHandler(this.btn_kurumlar_sil_Click);
            // 
            // btn_kurumlar_guncelle
            // 
            this.btn_kurumlar_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kurumlar_guncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_kurumlar_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kurumlar_guncelle.Location = new System.Drawing.Point(0, 358);
            this.btn_kurumlar_guncelle.Name = "btn_kurumlar_guncelle";
            this.btn_kurumlar_guncelle.Size = new System.Drawing.Size(430, 45);
            this.btn_kurumlar_guncelle.TabIndex = 1;
            this.btn_kurumlar_guncelle.Text = "GUNCELLE";
            this.btn_kurumlar_guncelle.UseVisualStyleBackColor = true;
            this.btn_kurumlar_guncelle.Click += new System.EventHandler(this.btn_kurumlar_guncelle_Click);
            // 
            // btn_kurumlar_ekle
            // 
            this.btn_kurumlar_ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kurumlar_ekle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_kurumlar_ekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kurumlar_ekle.Location = new System.Drawing.Point(0, 403);
            this.btn_kurumlar_ekle.Name = "btn_kurumlar_ekle";
            this.btn_kurumlar_ekle.Size = new System.Drawing.Size(430, 45);
            this.btn_kurumlar_ekle.TabIndex = 2;
            this.btn_kurumlar_ekle.Text = "EKLE";
            this.btn_kurumlar_ekle.UseVisualStyleBackColor = true;
            this.btn_kurumlar_ekle.Click += new System.EventHandler(this.btn_kurumlar_ekle_Click);
            // 
            // dataGridView_kurumlar
            // 
            this.dataGridView_kurumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kurumlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_kurumlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_kurumlar.Name = "dataGridView_kurumlar";
            this.dataGridView_kurumlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kurumlar.Size = new System.Drawing.Size(430, 312);
            this.dataGridView_kurumlar.TabIndex = 1;
            this.dataGridView_kurumlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kurumlar_CellClick);
            // 
            // tabPage_ilaclar
            // 
            this.tabPage_ilaclar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage_ilaclar.Controls.Add(this.btn_ilacsil);
            this.tabPage_ilaclar.Controls.Add(this.btn_guncelle);
            this.tabPage_ilaclar.Controls.Add(this.btn_ilacekle);
            this.tabPage_ilaclar.Controls.Add(this.dataGridView_ilaclar);
            this.tabPage_ilaclar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ilaclar.Name = "tabPage_ilaclar";
            this.tabPage_ilaclar.Size = new System.Drawing.Size(430, 448);
            this.tabPage_ilaclar.TabIndex = 3;
            this.tabPage_ilaclar.Text = "ILACLAR";
            // 
            // btn_ilacsil
            // 
            this.btn_ilacsil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ilacsil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ilacsil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ilacsil.Location = new System.Drawing.Point(0, 313);
            this.btn_ilacsil.Name = "btn_ilacsil";
            this.btn_ilacsil.Size = new System.Drawing.Size(430, 45);
            this.btn_ilacsil.TabIndex = 0;
            this.btn_ilacsil.Text = "ILACI SIL";
            this.btn_ilacsil.UseVisualStyleBackColor = true;
            this.btn_ilacsil.Click += new System.EventHandler(this.btn_ilacsil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guncelle.Location = new System.Drawing.Point(0, 358);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(430, 45);
            this.btn_guncelle.TabIndex = 1;
            this.btn_guncelle.Text = "GUNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ilacekle
            // 
            this.btn_ilacekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ilacekle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ilacekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ilacekle.Location = new System.Drawing.Point(0, 403);
            this.btn_ilacekle.Name = "btn_ilacekle";
            this.btn_ilacekle.Size = new System.Drawing.Size(430, 45);
            this.btn_ilacekle.TabIndex = 2;
            this.btn_ilacekle.Text = "ILAC EKLE";
            this.btn_ilacekle.UseVisualStyleBackColor = true;
            this.btn_ilacekle.Click += new System.EventHandler(this.btn_ilacekle_Click);
            // 
            // dataGridView_ilaclar
            // 
            this.dataGridView_ilaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ilaclar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_ilaclar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ilaclar.Name = "dataGridView_ilaclar";
            this.dataGridView_ilaclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ilaclar.Size = new System.Drawing.Size(430, 312);
            this.dataGridView_ilaclar.TabIndex = 1;
            this.dataGridView_ilaclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ilaclar_CellClick);
            // 
            // tabPage_islemler
            // 
            this.tabPage_islemler.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage_islemler.Controls.Add(this.btn_islemler_islemsil);
            this.tabPage_islemler.Controls.Add(this.btn_islemler_islemguncelle);
            this.tabPage_islemler.Controls.Add(this.btn_islemler_islemekle);
            this.tabPage_islemler.Controls.Add(this.dataGridView_islemler);
            this.tabPage_islemler.Location = new System.Drawing.Point(4, 22);
            this.tabPage_islemler.Name = "tabPage_islemler";
            this.tabPage_islemler.Size = new System.Drawing.Size(430, 448);
            this.tabPage_islemler.TabIndex = 4;
            this.tabPage_islemler.Text = "ISLEMLER";
            // 
            // btn_islemler_islemsil
            // 
            this.btn_islemler_islemsil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_islemler_islemsil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_islemler_islemsil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_islemler_islemsil.Location = new System.Drawing.Point(0, 313);
            this.btn_islemler_islemsil.Name = "btn_islemler_islemsil";
            this.btn_islemler_islemsil.Size = new System.Drawing.Size(430, 45);
            this.btn_islemler_islemsil.TabIndex = 0;
            this.btn_islemler_islemsil.Text = "SIL";
            this.btn_islemler_islemsil.UseVisualStyleBackColor = true;
            this.btn_islemler_islemsil.Click += new System.EventHandler(this.btn_islemler_islemsil_Click);
            // 
            // btn_islemler_islemguncelle
            // 
            this.btn_islemler_islemguncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_islemler_islemguncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_islemler_islemguncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_islemler_islemguncelle.Location = new System.Drawing.Point(0, 358);
            this.btn_islemler_islemguncelle.Name = "btn_islemler_islemguncelle";
            this.btn_islemler_islemguncelle.Size = new System.Drawing.Size(430, 45);
            this.btn_islemler_islemguncelle.TabIndex = 1;
            this.btn_islemler_islemguncelle.Text = "GUNCELLE";
            this.btn_islemler_islemguncelle.UseVisualStyleBackColor = true;
            this.btn_islemler_islemguncelle.Click += new System.EventHandler(this.btn_islemler_islemguncelle_Click);
            // 
            // btn_islemler_islemekle
            // 
            this.btn_islemler_islemekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_islemler_islemekle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_islemler_islemekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_islemler_islemekle.Location = new System.Drawing.Point(0, 403);
            this.btn_islemler_islemekle.Name = "btn_islemler_islemekle";
            this.btn_islemler_islemekle.Size = new System.Drawing.Size(430, 45);
            this.btn_islemler_islemekle.TabIndex = 2;
            this.btn_islemler_islemekle.Text = "EKLE";
            this.btn_islemler_islemekle.UseVisualStyleBackColor = true;
            this.btn_islemler_islemekle.Click += new System.EventHandler(this.btn_islemler_islemekle_Click);
            // 
            // dataGridView_islemler
            // 
            this.dataGridView_islemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_islemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_islemler.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_islemler.Name = "dataGridView_islemler";
            this.dataGridView_islemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_islemler.Size = new System.Drawing.Size(430, 312);
            this.dataGridView_islemler.TabIndex = 1;
            this.dataGridView_islemler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_islemler_CellClick);
            // 
            // tabPage_odemeturleri
            // 
            this.tabPage_odemeturleri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage_odemeturleri.Controls.Add(this.btn_odemetursil);
            this.tabPage_odemeturleri.Controls.Add(this.btn_odemeturguncelle);
            this.tabPage_odemeturleri.Controls.Add(this.btn_odemeturekle);
            this.tabPage_odemeturleri.Controls.Add(this.dataGridView_odemeturleri);
            this.tabPage_odemeturleri.Location = new System.Drawing.Point(4, 22);
            this.tabPage_odemeturleri.Name = "tabPage_odemeturleri";
            this.tabPage_odemeturleri.Size = new System.Drawing.Size(430, 448);
            this.tabPage_odemeturleri.TabIndex = 5;
            this.tabPage_odemeturleri.Text = "ODEME TURLERI";
            // 
            // btn_odemetursil
            // 
            this.btn_odemetursil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_odemetursil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_odemetursil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_odemetursil.Location = new System.Drawing.Point(0, 313);
            this.btn_odemetursil.Name = "btn_odemetursil";
            this.btn_odemetursil.Size = new System.Drawing.Size(430, 45);
            this.btn_odemetursil.TabIndex = 0;
            this.btn_odemetursil.Text = "SIL";
            this.btn_odemetursil.UseVisualStyleBackColor = true;
            this.btn_odemetursil.Click += new System.EventHandler(this.btn_odemetursil_Click);
            // 
            // btn_odemeturguncelle
            // 
            this.btn_odemeturguncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_odemeturguncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_odemeturguncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_odemeturguncelle.Location = new System.Drawing.Point(0, 358);
            this.btn_odemeturguncelle.Name = "btn_odemeturguncelle";
            this.btn_odemeturguncelle.Size = new System.Drawing.Size(430, 45);
            this.btn_odemeturguncelle.TabIndex = 1;
            this.btn_odemeturguncelle.Text = "GUNCELLE";
            this.btn_odemeturguncelle.UseVisualStyleBackColor = true;
            this.btn_odemeturguncelle.Click += new System.EventHandler(this.btn_odemeturguncelle_Click);
            // 
            // btn_odemeturekle
            // 
            this.btn_odemeturekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_odemeturekle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_odemeturekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_odemeturekle.Location = new System.Drawing.Point(0, 403);
            this.btn_odemeturekle.Name = "btn_odemeturekle";
            this.btn_odemeturekle.Size = new System.Drawing.Size(430, 45);
            this.btn_odemeturekle.TabIndex = 2;
            this.btn_odemeturekle.Text = "EKLE";
            this.btn_odemeturekle.UseVisualStyleBackColor = true;
            this.btn_odemeturekle.Click += new System.EventHandler(this.btn_odemeturekle_Click);
            // 
            // dataGridView_odemeturleri
            // 
            this.dataGridView_odemeturleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_odemeturleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_odemeturleri.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_odemeturleri.Name = "dataGridView_odemeturleri";
            this.dataGridView_odemeturleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_odemeturleri.Size = new System.Drawing.Size(430, 312);
            this.dataGridView_odemeturleri.TabIndex = 1;
            this.dataGridView_odemeturleri.TabStop = false;
            this.dataGridView_odemeturleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_odemeturleri_CellClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(438, 474);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "TANIMLAMA SAYFASI";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_iller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_iller)).EndInit();
            this.tabPage_ilceler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilceler)).EndInit();
            this.tabPage_kurumlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kurumlar)).EndInit();
            this.tabPage_ilaclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilaclar)).EndInit();
            this.tabPage_islemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_islemler)).EndInit();
            this.tabPage_odemeturleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_odemeturleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_iller;
        private System.Windows.Forms.DataGridView dataGridView_iller;
        private System.Windows.Forms.TabPage tabPage_ilceler;
        private System.Windows.Forms.TabPage tabPage_kurumlar;
        private System.Windows.Forms.TabPage tabPage_ilaclar;
        private System.Windows.Forms.TabPage tabPage_islemler;
        private System.Windows.Forms.TabPage tabPage_odemeturleri;
        private System.Windows.Forms.DataGridView dataGridView_ilceler;
        private System.Windows.Forms.DataGridView dataGridView_kurumlar;
        private System.Windows.Forms.DataGridView dataGridView_ilaclar;
        private System.Windows.Forms.DataGridView dataGridView_islemler;
        private System.Windows.Forms.DataGridView dataGridView_odemeturleri;
        private System.Windows.Forms.Button btn_iller_sil;
        private System.Windows.Forms.Button btn_iller_guncelle;
        private System.Windows.Forms.Button btn_iller_ekle;
        private System.Windows.Forms.Button btn_kurumlar_sil;
        private System.Windows.Forms.Button btn_kurumlar_guncelle;
        private System.Windows.Forms.Button btn_kurumlar_ekle;
        private System.Windows.Forms.Button btn_ilacsil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ilacekle;
        private System.Windows.Forms.Button btn_islemler_islemsil;
        private System.Windows.Forms.Button btn_islemler_islemguncelle;
        private System.Windows.Forms.Button btn_islemler_islemekle;
        private System.Windows.Forms.Button btn_odemetursil;
        private System.Windows.Forms.Button btn_odemeturguncelle;
        private System.Windows.Forms.Button btn_odemeturekle;
        private System.Windows.Forms.Button btn_ilceler_sil;
        private System.Windows.Forms.Button btn_ilceler_guncelle;
        private System.Windows.Forms.Button btn_ilceler_ekle;
    }
}