namespace WindowsFormsApplication5
{
    partial class HASTA_BILGI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HASTA_BILGI));
            this.dataGridView_hastalar = new System.Windows.Forms.DataGridView();
            this.groupBox_hastabilgi = new System.Windows.Forms.GroupBox();
            this.cmb_hastabilgi_yasadigiil = new System.Windows.Forms.ComboBox();
            this.txt_hastabilgi_istel = new System.Windows.Forms.TextBox();
            this.txt_hastabilgi_ceptel = new System.Windows.Forms.TextBox();
            this.txt_hastabilgi_evtel = new System.Windows.Forms.TextBox();
            this.cmb_hastabilgi_dogumyeri = new System.Windows.Forms.ComboBox();
            this.btn_hastabilgi_hastasil = new System.Windows.Forms.Button();
            this.rdb_hastabilgi_cinsiyetkadin = new System.Windows.Forms.RadioButton();
            this.rdb_hastabilgi_cinsiyeterkek = new System.Windows.Forms.RadioButton();
            this.btn_hastabilgileri_HastaGuncelle = new System.Windows.Forms.Button();
            this.btn_hastabilgiler_HastaEkle = new System.Windows.Forms.Button();
            this.lbl_hastabilgi_istel = new System.Windows.Forms.Label();
            this.lbl_hsatabilgi_ceptel = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_evtel = new System.Windows.Forms.Label();
            this.txt_hastabilgi_adres = new System.Windows.Forms.TextBox();
            this.lbl_hastabilgi_adres = new System.Windows.Forms.Label();
            this.cmb_hastabilgi_kurum = new System.Windows.Forms.ComboBox();
            this.lbl_hastabilgi_kurumid = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_dogumyeri = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_dogumtarihi = new System.Windows.Forms.Label();
            this.dateTimePicker_hastabilgi_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_hastabilgi_kangruburh = new System.Windows.Forms.ComboBox();
            this.lbl_hastabilgi_TC = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_kangrubu = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_Adi = new System.Windows.Forms.Label();
            this.cmb_hastabilgi_kangrubu = new System.Windows.Forms.ComboBox();
            this.lbl_hastabilgi_Soyadi = new System.Windows.Forms.Label();
            this.cmb_hastabilgi_yasadigiilce = new System.Windows.Forms.ComboBox();
            this.lbl_hastabilgi_AnneAdi = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_yasadigiilce = new System.Windows.Forms.Label();
            this.lbl_hastabilgi_BabaAdi = new System.Windows.Forms.Label();
            this.txt_hastabilgi_tc = new System.Windows.Forms.TextBox();
            this.lbl_hastabilgi_yasadigiil = new System.Windows.Forms.Label();
            this.txt_hastabilgi_Adi = new System.Windows.Forms.TextBox();
            this.lbl_hastabilgi_medenihali = new System.Windows.Forms.Label();
            this.txt_hastabilgi_Soyadi = new System.Windows.Forms.TextBox();
            this.cmb_hastabilgi_medenihali = new System.Windows.Forms.ComboBox();
            this.txt_hastabilgi_AnneAdi = new System.Windows.Forms.TextBox();
            this.lbl_hastabilgi_Cinsiyet = new System.Windows.Forms.Label();
            this.txt_hastabilgi_BabaAdi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).BeginInit();
            this.groupBox_hastabilgi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_hastalar
            // 
            this.dataGridView_hastalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hastalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_hastalar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_hastalar.MultiSelect = false;
            this.dataGridView_hastalar.Name = "dataGridView_hastalar";
            this.dataGridView_hastalar.Size = new System.Drawing.Size(1350, 358);
            this.dataGridView_hastalar.TabIndex = 2;
            this.dataGridView_hastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox_hastabilgi
            // 
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_yasadigiil);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_istel);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_ceptel);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_evtel);
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_dogumyeri);
            this.groupBox_hastabilgi.Controls.Add(this.btn_hastabilgi_hastasil);
            this.groupBox_hastabilgi.Controls.Add(this.rdb_hastabilgi_cinsiyetkadin);
            this.groupBox_hastabilgi.Controls.Add(this.rdb_hastabilgi_cinsiyeterkek);
            this.groupBox_hastabilgi.Controls.Add(this.btn_hastabilgileri_HastaGuncelle);
            this.groupBox_hastabilgi.Controls.Add(this.btn_hastabilgiler_HastaEkle);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_istel);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hsatabilgi_ceptel);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_evtel);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_adres);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_adres);
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_kurum);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_kurumid);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_dogumyeri);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_dogumtarihi);
            this.groupBox_hastabilgi.Controls.Add(this.dateTimePicker_hastabilgi_dogumtarihi);
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_kangruburh);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_TC);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_kangrubu);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_Adi);
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_kangrubu);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_Soyadi);
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_yasadigiilce);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_AnneAdi);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_yasadigiilce);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_BabaAdi);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_tc);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_yasadigiil);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_Adi);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_medenihali);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_Soyadi);
            this.groupBox_hastabilgi.Controls.Add(this.cmb_hastabilgi_medenihali);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_AnneAdi);
            this.groupBox_hastabilgi.Controls.Add(this.lbl_hastabilgi_Cinsiyet);
            this.groupBox_hastabilgi.Controls.Add(this.txt_hastabilgi_BabaAdi);
            this.groupBox_hastabilgi.Controls.Add(this.comboBox1);
            this.groupBox_hastabilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_hastabilgi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_hastabilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox_hastabilgi.Location = new System.Drawing.Point(0, 364);
            this.groupBox_hastabilgi.Name = "groupBox_hastabilgi";
            this.groupBox_hastabilgi.Size = new System.Drawing.Size(1350, 365);
            this.groupBox_hastabilgi.TabIndex = 3;
            this.groupBox_hastabilgi.TabStop = false;
            this.groupBox_hastabilgi.Text = "BILGILER";
            // 
            // cmb_hastabilgi_yasadigiil
            // 
            this.cmb_hastabilgi_yasadigiil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_hastabilgi_yasadigiil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_hastabilgi_yasadigiil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_hastabilgi_yasadigiil.FormattingEnabled = true;
            this.cmb_hastabilgi_yasadigiil.Location = new System.Drawing.Point(881, 30);
            this.cmb_hastabilgi_yasadigiil.Name = "cmb_hastabilgi_yasadigiil";
            this.cmb_hastabilgi_yasadigiil.Size = new System.Drawing.Size(121, 21);
            this.cmb_hastabilgi_yasadigiil.TabIndex = 84;
            this.cmb_hastabilgi_yasadigiil.SelectedIndexChanged += new System.EventHandler(this.cmb_hastabilgi_yasadigiil_SelectedIndexChanged);
            // 
            // txt_hastabilgi_istel
            // 
            this.txt_hastabilgi_istel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_hastabilgi_istel.Location = new System.Drawing.Point(881, 288);
            this.txt_hastabilgi_istel.MaxLength = 11;
            this.txt_hastabilgi_istel.Name = "txt_hastabilgi_istel";
            this.txt_hastabilgi_istel.Size = new System.Drawing.Size(116, 21);
            this.txt_hastabilgi_istel.TabIndex = 83;
            this.txt_hastabilgi_istel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_istel_KeyPress);
            // 
            // txt_hastabilgi_ceptel
            // 
            this.txt_hastabilgi_ceptel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_hastabilgi_ceptel.Location = new System.Drawing.Point(881, 223);
            this.txt_hastabilgi_ceptel.MaxLength = 11;
            this.txt_hastabilgi_ceptel.Name = "txt_hastabilgi_ceptel";
            this.txt_hastabilgi_ceptel.Size = new System.Drawing.Size(116, 21);
            this.txt_hastabilgi_ceptel.TabIndex = 82;
            this.txt_hastabilgi_ceptel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_ceptel_KeyPress);
            // 
            // txt_hastabilgi_evtel
            // 
            this.txt_hastabilgi_evtel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_hastabilgi_evtel.Location = new System.Drawing.Point(881, 158);
            this.txt_hastabilgi_evtel.MaxLength = 11;
            this.txt_hastabilgi_evtel.Name = "txt_hastabilgi_evtel";
            this.txt_hastabilgi_evtel.Size = new System.Drawing.Size(116, 21);
            this.txt_hastabilgi_evtel.TabIndex = 81;
            this.txt_hastabilgi_evtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_evtel_KeyPress);
            // 
            // cmb_hastabilgi_dogumyeri
            // 
            this.cmb_hastabilgi_dogumyeri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_hastabilgi_dogumyeri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_hastabilgi_dogumyeri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_hastabilgi_dogumyeri.FormattingEnabled = true;
            this.cmb_hastabilgi_dogumyeri.Location = new System.Drawing.Point(131, 327);
            this.cmb_hastabilgi_dogumyeri.Name = "cmb_hastabilgi_dogumyeri";
            this.cmb_hastabilgi_dogumyeri.Size = new System.Drawing.Size(128, 21);
            this.cmb_hastabilgi_dogumyeri.TabIndex = 79;
            // 
            // btn_hastabilgi_hastasil
            // 
            this.btn_hastabilgi_hastasil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hastabilgi_hastasil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastabilgi_hastasil.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_hastabilgi_hastasil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_hastabilgi_hastasil.Location = new System.Drawing.Point(1143, 247);
            this.btn_hastabilgi_hastasil.Name = "btn_hastabilgi_hastasil";
            this.btn_hastabilgi_hastasil.Size = new System.Drawing.Size(181, 71);
            this.btn_hastabilgi_hastasil.TabIndex = 78;
            this.btn_hastabilgi_hastasil.Text = "KAYDI SIL";
            this.btn_hastabilgi_hastasil.UseVisualStyleBackColor = true;
            this.btn_hastabilgi_hastasil.Click += new System.EventHandler(this.btn_hastabilgi_hastasil_Click);
            // 
            // rdb_hastabilgi_cinsiyetkadin
            // 
            this.rdb_hastabilgi_cinsiyetkadin.AutoSize = true;
            this.rdb_hastabilgi_cinsiyetkadin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_hastabilgi_cinsiyetkadin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdb_hastabilgi_cinsiyetkadin.Location = new System.Drawing.Point(508, 225);
            this.rdb_hastabilgi_cinsiyetkadin.Name = "rdb_hastabilgi_cinsiyetkadin";
            this.rdb_hastabilgi_cinsiyetkadin.Size = new System.Drawing.Size(51, 17);
            this.rdb_hastabilgi_cinsiyetkadin.TabIndex = 74;
            this.rdb_hastabilgi_cinsiyetkadin.TabStop = true;
            this.rdb_hastabilgi_cinsiyetkadin.Text = "Kadın";
            this.rdb_hastabilgi_cinsiyetkadin.UseVisualStyleBackColor = true;
            // 
            // rdb_hastabilgi_cinsiyeterkek
            // 
            this.rdb_hastabilgi_cinsiyeterkek.AutoSize = true;
            this.rdb_hastabilgi_cinsiyeterkek.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_hastabilgi_cinsiyeterkek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdb_hastabilgi_cinsiyeterkek.Location = new System.Drawing.Point(592, 225);
            this.rdb_hastabilgi_cinsiyeterkek.Name = "rdb_hastabilgi_cinsiyeterkek";
            this.rdb_hastabilgi_cinsiyeterkek.Size = new System.Drawing.Size(51, 17);
            this.rdb_hastabilgi_cinsiyeterkek.TabIndex = 73;
            this.rdb_hastabilgi_cinsiyeterkek.TabStop = true;
            this.rdb_hastabilgi_cinsiyeterkek.Text = "Erkek";
            this.rdb_hastabilgi_cinsiyeterkek.UseVisualStyleBackColor = true;
            // 
            // btn_hastabilgileri_HastaGuncelle
            // 
            this.btn_hastabilgileri_HastaGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hastabilgileri_HastaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastabilgileri_HastaGuncelle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_hastabilgileri_HastaGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_hastabilgileri_HastaGuncelle.Location = new System.Drawing.Point(1143, 149);
            this.btn_hastabilgileri_HastaGuncelle.Name = "btn_hastabilgileri_HastaGuncelle";
            this.btn_hastabilgileri_HastaGuncelle.Size = new System.Drawing.Size(181, 71);
            this.btn_hastabilgileri_HastaGuncelle.TabIndex = 72;
            this.btn_hastabilgileri_HastaGuncelle.Text = "BILGILERI GUNCELLE";
            this.btn_hastabilgileri_HastaGuncelle.UseVisualStyleBackColor = true;
            this.btn_hastabilgileri_HastaGuncelle.Click += new System.EventHandler(this.btn_hastabilgileri_HastaGuncelle_Click);
            // 
            // btn_hastabilgiler_HastaEkle
            // 
            this.btn_hastabilgiler_HastaEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hastabilgiler_HastaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastabilgiler_HastaEkle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_hastabilgiler_HastaEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_hastabilgiler_HastaEkle.Location = new System.Drawing.Point(1143, 55);
            this.btn_hastabilgiler_HastaEkle.Name = "btn_hastabilgiler_HastaEkle";
            this.btn_hastabilgiler_HastaEkle.Size = new System.Drawing.Size(181, 65);
            this.btn_hastabilgiler_HastaEkle.TabIndex = 71;
            this.btn_hastabilgiler_HastaEkle.Text = "HASTA EKLE";
            this.btn_hastabilgiler_HastaEkle.UseVisualStyleBackColor = true;
            this.btn_hastabilgiler_HastaEkle.Click += new System.EventHandler(this.btn_hastabilgiler_HastaEkle_Click);
            // 
            // lbl_hastabilgi_istel
            // 
            this.lbl_hastabilgi_istel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hastabilgi_istel.AutoSize = true;
            this.lbl_hastabilgi_istel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_istel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_istel.Location = new System.Drawing.Point(749, 293);
            this.lbl_hastabilgi_istel.Name = "lbl_hastabilgi_istel";
            this.lbl_hastabilgi_istel.Size = new System.Drawing.Size(76, 13);
            this.lbl_hastabilgi_istel.TabIndex = 67;
            this.lbl_hastabilgi_istel.Text = "İş Telefonu :";
            // 
            // lbl_hsatabilgi_ceptel
            // 
            this.lbl_hsatabilgi_ceptel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hsatabilgi_ceptel.AutoSize = true;
            this.lbl_hsatabilgi_ceptel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hsatabilgi_ceptel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hsatabilgi_ceptel.Location = new System.Drawing.Point(749, 227);
            this.lbl_hsatabilgi_ceptel.Name = "lbl_hsatabilgi_ceptel";
            this.lbl_hsatabilgi_ceptel.Size = new System.Drawing.Size(86, 13);
            this.lbl_hsatabilgi_ceptel.TabIndex = 66;
            this.lbl_hsatabilgi_ceptel.Text = "Cep Telefonu :";
            // 
            // lbl_hastabilgi_evtel
            // 
            this.lbl_hastabilgi_evtel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hastabilgi_evtel.AutoSize = true;
            this.lbl_hastabilgi_evtel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_evtel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_evtel.Location = new System.Drawing.Point(749, 162);
            this.lbl_hastabilgi_evtel.Name = "lbl_hastabilgi_evtel";
            this.lbl_hastabilgi_evtel.Size = new System.Drawing.Size(78, 13);
            this.lbl_hastabilgi_evtel.TabIndex = 65;
            this.lbl_hastabilgi_evtel.Text = "Ev Telefonu :";
            // 
            // txt_hastabilgi_adres
            // 
            this.txt_hastabilgi_adres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_hastabilgi_adres.Location = new System.Drawing.Point(492, 273);
            this.txt_hastabilgi_adres.Multiline = true;
            this.txt_hastabilgi_adres.Name = "txt_hastabilgi_adres";
            this.txt_hastabilgi_adres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_hastabilgi_adres.Size = new System.Drawing.Size(208, 86);
            this.txt_hastabilgi_adres.TabIndex = 64;
            // 
            // lbl_hastabilgi_adres
            // 
            this.lbl_hastabilgi_adres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hastabilgi_adres.AutoSize = true;
            this.lbl_hastabilgi_adres.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_adres.Location = new System.Drawing.Point(347, 293);
            this.lbl_hastabilgi_adres.Name = "lbl_hastabilgi_adres";
            this.lbl_hastabilgi_adres.Size = new System.Drawing.Size(49, 13);
            this.lbl_hastabilgi_adres.TabIndex = 63;
            this.lbl_hastabilgi_adres.Text = "Adres : ";
            // 
            // cmb_hastabilgi_kurum
            // 
            this.cmb_hastabilgi_kurum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_hastabilgi_kurum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_hastabilgi_kurum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_hastabilgi_kurum.FormattingEnabled = true;
            this.cmb_hastabilgi_kurum.Location = new System.Drawing.Point(498, 158);
            this.cmb_hastabilgi_kurum.Name = "cmb_hastabilgi_kurum";
            this.cmb_hastabilgi_kurum.Size = new System.Drawing.Size(140, 21);
            this.cmb_hastabilgi_kurum.TabIndex = 62;
            // 
            // lbl_hastabilgi_kurumid
            // 
            this.lbl_hastabilgi_kurumid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_hastabilgi_kurumid.AutoSize = true;
            this.lbl_hastabilgi_kurumid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_kurumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_kurumid.Location = new System.Drawing.Point(345, 162);
            this.lbl_hastabilgi_kurumid.Name = "lbl_hastabilgi_kurumid";
            this.lbl_hastabilgi_kurumid.Size = new System.Drawing.Size(53, 13);
            this.lbl_hastabilgi_kurumid.TabIndex = 61;
            this.lbl_hastabilgi_kurumid.Text = "Kurum : ";
            // 
            // lbl_hastabilgi_dogumyeri
            // 
            this.lbl_hastabilgi_dogumyeri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_dogumyeri.AutoSize = true;
            this.lbl_hastabilgi_dogumyeri.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_dogumyeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_dogumyeri.Location = new System.Drawing.Point(14, 331);
            this.lbl_hastabilgi_dogumyeri.Name = "lbl_hastabilgi_dogumyeri";
            this.lbl_hastabilgi_dogumyeri.Size = new System.Drawing.Size(82, 13);
            this.lbl_hastabilgi_dogumyeri.TabIndex = 60;
            this.lbl_hastabilgi_dogumyeri.Text = "Dogum_Yeri :";
            // 
            // lbl_hastabilgi_dogumtarihi
            // 
            this.lbl_hastabilgi_dogumtarihi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_dogumtarihi.AutoSize = true;
            this.lbl_hastabilgi_dogumtarihi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_dogumtarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_dogumtarihi.Location = new System.Drawing.Point(14, 277);
            this.lbl_hastabilgi_dogumtarihi.Name = "lbl_hastabilgi_dogumtarihi";
            this.lbl_hastabilgi_dogumtarihi.Size = new System.Drawing.Size(92, 13);
            this.lbl_hastabilgi_dogumtarihi.TabIndex = 59;
            this.lbl_hastabilgi_dogumtarihi.Text = "Dogum_Tarihi :";
            // 
            // dateTimePicker_hastabilgi_dogumtarihi
            // 
            this.dateTimePicker_hastabilgi_dogumtarihi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_hastabilgi_dogumtarihi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker_hastabilgi_dogumtarihi.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker_hastabilgi_dogumtarihi.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_hastabilgi_dogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_hastabilgi_dogumtarihi.Location = new System.Drawing.Point(131, 273);
            this.dateTimePicker_hastabilgi_dogumtarihi.Name = "dateTimePicker_hastabilgi_dogumtarihi";
            this.dateTimePicker_hastabilgi_dogumtarihi.Size = new System.Drawing.Size(128, 21);
            this.dateTimePicker_hastabilgi_dogumtarihi.TabIndex = 58;
            // 
            // cmb_hastabilgi_kangruburh
            // 
            this.cmb_hastabilgi_kangruburh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_hastabilgi_kangruburh.FormattingEnabled = true;
            this.cmb_hastabilgi_kangruburh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmb_hastabilgi_kangruburh.Location = new System.Drawing.Point(660, 28);
            this.cmb_hastabilgi_kangruburh.Name = "cmb_hastabilgi_kangruburh";
            this.cmb_hastabilgi_kangruburh.Size = new System.Drawing.Size(59, 21);
            this.cmb_hastabilgi_kangruburh.TabIndex = 57;
            // 
            // lbl_hastabilgi_TC
            // 
            this.lbl_hastabilgi_TC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_TC.AutoSize = true;
            this.lbl_hastabilgi_TC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_TC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_TC.Location = new System.Drawing.Point(14, 32);
            this.lbl_hastabilgi_TC.Name = "lbl_hastabilgi_TC";
            this.lbl_hastabilgi_TC.Size = new System.Drawing.Size(84, 13);
            this.lbl_hastabilgi_TC.TabIndex = 37;
            this.lbl_hastabilgi_TC.Text = "TC Kimlik No : ";
            // 
            // lbl_hastabilgi_kangrubu
            // 
            this.lbl_hastabilgi_kangrubu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_hastabilgi_kangrubu.AutoSize = true;
            this.lbl_hastabilgi_kangrubu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_kangrubu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_kangrubu.Location = new System.Drawing.Point(345, 32);
            this.lbl_hastabilgi_kangrubu.Name = "lbl_hastabilgi_kangrubu";
            this.lbl_hastabilgi_kangrubu.Size = new System.Drawing.Size(71, 13);
            this.lbl_hastabilgi_kangrubu.TabIndex = 56;
            this.lbl_hastabilgi_kangrubu.Text = "Kan Grubu :";
            // 
            // lbl_hastabilgi_Adi
            // 
            this.lbl_hastabilgi_Adi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_Adi.AutoSize = true;
            this.lbl_hastabilgi_Adi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_Adi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_Adi.Location = new System.Drawing.Point(14, 81);
            this.lbl_hastabilgi_Adi.Name = "lbl_hastabilgi_Adi";
            this.lbl_hastabilgi_Adi.Size = new System.Drawing.Size(34, 13);
            this.lbl_hastabilgi_Adi.TabIndex = 38;
            this.lbl_hastabilgi_Adi.Text = "Adı : ";
            // 
            // cmb_hastabilgi_kangrubu
            // 
            this.cmb_hastabilgi_kangrubu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_hastabilgi_kangrubu.FormattingEnabled = true;
            this.cmb_hastabilgi_kangrubu.Items.AddRange(new object[] {
            "A Rh",
            "B Rh",
            "AB Rh",
            "0 Rh"});
            this.cmb_hastabilgi_kangrubu.Location = new System.Drawing.Point(498, 28);
            this.cmb_hastabilgi_kangrubu.Name = "cmb_hastabilgi_kangrubu";
            this.cmb_hastabilgi_kangrubu.Size = new System.Drawing.Size(140, 21);
            this.cmb_hastabilgi_kangrubu.TabIndex = 55;
            // 
            // lbl_hastabilgi_Soyadi
            // 
            this.lbl_hastabilgi_Soyadi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_Soyadi.AutoSize = true;
            this.lbl_hastabilgi_Soyadi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_Soyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_Soyadi.Location = new System.Drawing.Point(14, 130);
            this.lbl_hastabilgi_Soyadi.Name = "lbl_hastabilgi_Soyadi";
            this.lbl_hastabilgi_Soyadi.Size = new System.Drawing.Size(54, 13);
            this.lbl_hastabilgi_Soyadi.TabIndex = 39;
            this.lbl_hastabilgi_Soyadi.Text = "Soyadı : ";
            // 
            // cmb_hastabilgi_yasadigiilce
            // 
            this.cmb_hastabilgi_yasadigiilce.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_hastabilgi_yasadigiilce.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_hastabilgi_yasadigiilce.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_hastabilgi_yasadigiilce.FormattingEnabled = true;
            this.cmb_hastabilgi_yasadigiilce.Location = new System.Drawing.Point(881, 93);
            this.cmb_hastabilgi_yasadigiilce.Name = "cmb_hastabilgi_yasadigiilce";
            this.cmb_hastabilgi_yasadigiilce.Size = new System.Drawing.Size(116, 21);
            this.cmb_hastabilgi_yasadigiilce.TabIndex = 54;
            this.cmb_hastabilgi_yasadigiilce.SelectedIndexChanged += new System.EventHandler(this.cmb_hastabilgi_yasadigiilce_SelectedIndexChanged);
            // 
            // lbl_hastabilgi_AnneAdi
            // 
            this.lbl_hastabilgi_AnneAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_AnneAdi.AutoSize = true;
            this.lbl_hastabilgi_AnneAdi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_AnneAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_AnneAdi.Location = new System.Drawing.Point(14, 179);
            this.lbl_hastabilgi_AnneAdi.Name = "lbl_hastabilgi_AnneAdi";
            this.lbl_hastabilgi_AnneAdi.Size = new System.Drawing.Size(66, 13);
            this.lbl_hastabilgi_AnneAdi.TabIndex = 40;
            this.lbl_hastabilgi_AnneAdi.Text = "Anne Adı : ";
            // 
            // lbl_hastabilgi_yasadigiilce
            // 
            this.lbl_hastabilgi_yasadigiilce.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hastabilgi_yasadigiilce.AutoSize = true;
            this.lbl_hastabilgi_yasadigiilce.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_yasadigiilce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_yasadigiilce.Location = new System.Drawing.Point(749, 97);
            this.lbl_hastabilgi_yasadigiilce.Name = "lbl_hastabilgi_yasadigiilce";
            this.lbl_hastabilgi_yasadigiilce.Size = new System.Drawing.Size(87, 13);
            this.lbl_hastabilgi_yasadigiilce.TabIndex = 53;
            this.lbl_hastabilgi_yasadigiilce.Text = "Yaşadığı İlçe : ";
            // 
            // lbl_hastabilgi_BabaAdi
            // 
            this.lbl_hastabilgi_BabaAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_hastabilgi_BabaAdi.AutoSize = true;
            this.lbl_hastabilgi_BabaAdi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_BabaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_BabaAdi.Location = new System.Drawing.Point(14, 228);
            this.lbl_hastabilgi_BabaAdi.Name = "lbl_hastabilgi_BabaAdi";
            this.lbl_hastabilgi_BabaAdi.Size = new System.Drawing.Size(65, 13);
            this.lbl_hastabilgi_BabaAdi.TabIndex = 41;
            this.lbl_hastabilgi_BabaAdi.Text = "Baba Adı : ";
            // 
            // txt_hastabilgi_tc
            // 
            this.txt_hastabilgi_tc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_hastabilgi_tc.Location = new System.Drawing.Point(131, 28);
            this.txt_hastabilgi_tc.MaxLength = 11;
            this.txt_hastabilgi_tc.Name = "txt_hastabilgi_tc";
            this.txt_hastabilgi_tc.Size = new System.Drawing.Size(128, 21);
            this.txt_hastabilgi_tc.TabIndex = 42;
            this.txt_hastabilgi_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_tc_KeyPress);
            // 
            // lbl_hastabilgi_yasadigiil
            // 
            this.lbl_hastabilgi_yasadigiil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hastabilgi_yasadigiil.AutoSize = true;
            this.lbl_hastabilgi_yasadigiil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_yasadigiil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_yasadigiil.Location = new System.Drawing.Point(749, 32);
            this.lbl_hastabilgi_yasadigiil.Name = "lbl_hastabilgi_yasadigiil";
            this.lbl_hastabilgi_yasadigiil.Size = new System.Drawing.Size(74, 13);
            this.lbl_hastabilgi_yasadigiil.TabIndex = 51;
            this.lbl_hastabilgi_yasadigiil.Text = "Yaşadığı İl : ";
            // 
            // txt_hastabilgi_Adi
            // 
            this.txt_hastabilgi_Adi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_hastabilgi_Adi.Location = new System.Drawing.Point(131, 77);
            this.txt_hastabilgi_Adi.MaxLength = 40;
            this.txt_hastabilgi_Adi.Name = "txt_hastabilgi_Adi";
            this.txt_hastabilgi_Adi.Size = new System.Drawing.Size(128, 21);
            this.txt_hastabilgi_Adi.TabIndex = 43;
            this.txt_hastabilgi_Adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_Adi_KeyPress);
            // 
            // lbl_hastabilgi_medenihali
            // 
            this.lbl_hastabilgi_medenihali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_hastabilgi_medenihali.AutoSize = true;
            this.lbl_hastabilgi_medenihali.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_medenihali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_medenihali.Location = new System.Drawing.Point(345, 97);
            this.lbl_hastabilgi_medenihali.Name = "lbl_hastabilgi_medenihali";
            this.lbl_hastabilgi_medenihali.Size = new System.Drawing.Size(81, 13);
            this.lbl_hastabilgi_medenihali.TabIndex = 50;
            this.lbl_hastabilgi_medenihali.Text = "Medeni Hali : ";
            // 
            // txt_hastabilgi_Soyadi
            // 
            this.txt_hastabilgi_Soyadi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_hastabilgi_Soyadi.Location = new System.Drawing.Point(131, 126);
            this.txt_hastabilgi_Soyadi.MaxLength = 40;
            this.txt_hastabilgi_Soyadi.Name = "txt_hastabilgi_Soyadi";
            this.txt_hastabilgi_Soyadi.Size = new System.Drawing.Size(128, 21);
            this.txt_hastabilgi_Soyadi.TabIndex = 44;
            this.txt_hastabilgi_Soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_Soyadi_KeyPress);
            // 
            // cmb_hastabilgi_medenihali
            // 
            this.cmb_hastabilgi_medenihali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_hastabilgi_medenihali.FormattingEnabled = true;
            this.cmb_hastabilgi_medenihali.Items.AddRange(new object[] {
            "Bekâr",
            "Evli"});
            this.cmb_hastabilgi_medenihali.Location = new System.Drawing.Point(498, 93);
            this.cmb_hastabilgi_medenihali.Name = "cmb_hastabilgi_medenihali";
            this.cmb_hastabilgi_medenihali.Size = new System.Drawing.Size(140, 21);
            this.cmb_hastabilgi_medenihali.TabIndex = 49;
            // 
            // txt_hastabilgi_AnneAdi
            // 
            this.txt_hastabilgi_AnneAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_hastabilgi_AnneAdi.Location = new System.Drawing.Point(131, 175);
            this.txt_hastabilgi_AnneAdi.MaxLength = 40;
            this.txt_hastabilgi_AnneAdi.Name = "txt_hastabilgi_AnneAdi";
            this.txt_hastabilgi_AnneAdi.Size = new System.Drawing.Size(128, 21);
            this.txt_hastabilgi_AnneAdi.TabIndex = 45;
            this.txt_hastabilgi_AnneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_AnneAdi_KeyPress);
            // 
            // lbl_hastabilgi_Cinsiyet
            // 
            this.lbl_hastabilgi_Cinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_hastabilgi_Cinsiyet.AutoSize = true;
            this.lbl_hastabilgi_Cinsiyet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hastabilgi_Cinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hastabilgi_Cinsiyet.Location = new System.Drawing.Point(345, 227);
            this.lbl_hastabilgi_Cinsiyet.Name = "lbl_hastabilgi_Cinsiyet";
            this.lbl_hastabilgi_Cinsiyet.Size = new System.Drawing.Size(64, 13);
            this.lbl_hastabilgi_Cinsiyet.TabIndex = 48;
            this.lbl_hastabilgi_Cinsiyet.Text = "Cinsiyeti : ";
            // 
            // txt_hastabilgi_BabaAdi
            // 
            this.txt_hastabilgi_BabaAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_hastabilgi_BabaAdi.Location = new System.Drawing.Point(131, 224);
            this.txt_hastabilgi_BabaAdi.MaxLength = 40;
            this.txt_hastabilgi_BabaAdi.Name = "txt_hastabilgi_BabaAdi";
            this.txt_hastabilgi_BabaAdi.Size = new System.Drawing.Size(128, 21);
            this.txt_hastabilgi_BabaAdi.TabIndex = 46;
            this.txt_hastabilgi_BabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hastabilgi_BabaAdi_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1167, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 87;
            this.comboBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_hastalar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 358);
            this.panel1.TabIndex = 4;
            // 
            // HASTA_BILGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_hastabilgi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HASTA_BILGI";
            this.Text = "Hasta Bilgileri";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalar)).EndInit();
            this.groupBox_hastabilgi.ResumeLayout(false);
            this.groupBox_hastabilgi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_hastalar;
        private System.Windows.Forms.GroupBox groupBox_hastabilgi;
        private System.Windows.Forms.Button btn_hastabilgileri_HastaGuncelle;
        private System.Windows.Forms.Button btn_hastabilgiler_HastaEkle;
        private System.Windows.Forms.Label lbl_hastabilgi_istel;
        private System.Windows.Forms.Label lbl_hsatabilgi_ceptel;
        private System.Windows.Forms.Label lbl_hastabilgi_evtel;
        private System.Windows.Forms.TextBox txt_hastabilgi_adres;
        private System.Windows.Forms.Label lbl_hastabilgi_adres;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_kurum;
        private System.Windows.Forms.Label lbl_hastabilgi_kurumid;
        private System.Windows.Forms.Label lbl_hastabilgi_dogumyeri;
        private System.Windows.Forms.Label lbl_hastabilgi_dogumtarihi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hastabilgi_dogumtarihi;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_kangruburh;
        private System.Windows.Forms.Label lbl_hastabilgi_TC;
        private System.Windows.Forms.Label lbl_hastabilgi_kangrubu;
        private System.Windows.Forms.Label lbl_hastabilgi_Adi;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_kangrubu;
        private System.Windows.Forms.Label lbl_hastabilgi_Soyadi;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_yasadigiilce;
        private System.Windows.Forms.Label lbl_hastabilgi_AnneAdi;
        private System.Windows.Forms.Label lbl_hastabilgi_yasadigiilce;
        private System.Windows.Forms.Label lbl_hastabilgi_BabaAdi;
        private System.Windows.Forms.TextBox txt_hastabilgi_tc;
        private System.Windows.Forms.Label lbl_hastabilgi_yasadigiil;
        private System.Windows.Forms.TextBox txt_hastabilgi_Adi;
        private System.Windows.Forms.Label lbl_hastabilgi_medenihali;
        private System.Windows.Forms.TextBox txt_hastabilgi_Soyadi;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_medenihali;
        private System.Windows.Forms.TextBox txt_hastabilgi_AnneAdi;
        private System.Windows.Forms.Label lbl_hastabilgi_Cinsiyet;
        private System.Windows.Forms.TextBox txt_hastabilgi_BabaAdi;
        private System.Windows.Forms.RadioButton rdb_hastabilgi_cinsiyetkadin;
        private System.Windows.Forms.RadioButton rdb_hastabilgi_cinsiyeterkek;
        private System.Windows.Forms.Button btn_hastabilgi_hastasil;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_dogumyeri;
        private System.Windows.Forms.TextBox txt_hastabilgi_istel;
        private System.Windows.Forms.TextBox txt_hastabilgi_ceptel;
        private System.Windows.Forms.TextBox txt_hastabilgi_evtel;
        private System.Windows.Forms.ComboBox cmb_hastabilgi_yasadigiil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

