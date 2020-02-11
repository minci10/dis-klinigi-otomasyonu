namespace WindowsFormsApplication5
{
    partial class ANASAYFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANASAYFA));
            this.btn_hastabilgiekrani = new System.Windows.Forms.Button();
            this.btn_randevuekrani = new System.Windows.Forms.Button();
            this.btn_kasaekrani = new System.Windows.Forms.Button();
            this.btn_muayeneekrani = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hastabilgiekrani
            // 
            this.btn_hastabilgiekrani.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastabilgiekrani.Location = new System.Drawing.Point(64, 24);
            this.btn_hastabilgiekrani.Name = "btn_hastabilgiekrani";
            this.btn_hastabilgiekrani.Size = new System.Drawing.Size(217, 58);
            this.btn_hastabilgiekrani.TabIndex = 0;
            this.btn_hastabilgiekrani.Text = "HASTA BİLGİLERİ EKRANI";
            this.btn_hastabilgiekrani.UseVisualStyleBackColor = true;
            this.btn_hastabilgiekrani.Click += new System.EventHandler(this.btn_hastabilgiekrani_Click);
            // 
            // btn_randevuekrani
            // 
            this.btn_randevuekrani.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_randevuekrani.Location = new System.Drawing.Point(64, 97);
            this.btn_randevuekrani.Name = "btn_randevuekrani";
            this.btn_randevuekrani.Size = new System.Drawing.Size(217, 58);
            this.btn_randevuekrani.TabIndex = 1;
            this.btn_randevuekrani.Text = "RANDEVU EKRANI";
            this.btn_randevuekrani.UseVisualStyleBackColor = true;
            this.btn_randevuekrani.Click += new System.EventHandler(this.btn_randevuekrani_Click);
            // 
            // btn_kasaekrani
            // 
            this.btn_kasaekrani.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_kasaekrani.Location = new System.Drawing.Point(64, 243);
            this.btn_kasaekrani.Name = "btn_kasaekrani";
            this.btn_kasaekrani.Size = new System.Drawing.Size(217, 58);
            this.btn_kasaekrani.TabIndex = 3;
            this.btn_kasaekrani.Text = "KASA";
            this.btn_kasaekrani.UseVisualStyleBackColor = true;
            this.btn_kasaekrani.Click += new System.EventHandler(this.btn_kasaekrani_Click);
            // 
            // btn_muayeneekrani
            // 
            this.btn_muayeneekrani.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_muayeneekrani.Location = new System.Drawing.Point(64, 170);
            this.btn_muayeneekrani.Name = "btn_muayeneekrani";
            this.btn_muayeneekrani.Size = new System.Drawing.Size(217, 58);
            this.btn_muayeneekrani.TabIndex = 2;
            this.btn_muayeneekrani.Text = "MUAYENE";
            this.btn_muayeneekrani.UseVisualStyleBackColor = true;
            this.btn_muayeneekrani.Click += new System.EventHandler(this.btn_muayeneekrani_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_cikis.Location = new System.Drawing.Point(64, 389);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(217, 58);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(64, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "TANIM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ANASAYFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_muayeneekrani);
            this.Controls.Add(this.btn_kasaekrani);
            this.Controls.Add(this.btn_randevuekrani);
            this.Controls.Add(this.btn_hastabilgiekrani);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "ANASAYFA";
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.ANASAYFA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hastabilgiekrani;
        private System.Windows.Forms.Button btn_randevuekrani;
        private System.Windows.Forms.Button btn_kasaekrani;
        private System.Windows.Forms.Button btn_muayeneekrani;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button button1;
    }
}