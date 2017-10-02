namespace Presentation
{
    partial class GrupListe
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
            this.lst_GrupListe = new System.Windows.Forms.ListBox();
            this.grp_EkleDuzenle = new System.Windows.Forms.GroupBox();
            this.btn_GrupEkle = new System.Windows.Forms.Button();
            this.txt_GrupAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.grp_EkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_GrupListe
            // 
            this.lst_GrupListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_GrupListe.FormattingEnabled = true;
            this.lst_GrupListe.ItemHeight = 29;
            this.lst_GrupListe.Location = new System.Drawing.Point(0, 0);
            this.lst_GrupListe.Name = "lst_GrupListe";
            this.lst_GrupListe.Size = new System.Drawing.Size(261, 314);
            this.lst_GrupListe.TabIndex = 0;
            // 
            // grp_EkleDuzenle
            // 
            this.grp_EkleDuzenle.Controls.Add(this.btn_GrupEkle);
            this.grp_EkleDuzenle.Controls.Add(this.txt_GrupAdi);
            this.grp_EkleDuzenle.Controls.Add(this.label1);
            this.grp_EkleDuzenle.Location = new System.Drawing.Point(282, 24);
            this.grp_EkleDuzenle.Name = "grp_EkleDuzenle";
            this.grp_EkleDuzenle.Size = new System.Drawing.Size(386, 192);
            this.grp_EkleDuzenle.TabIndex = 1;
            this.grp_EkleDuzenle.TabStop = false;
            this.grp_EkleDuzenle.Text = "Yeni Grup Ekle";
            // 
            // btn_GrupEkle
            // 
            this.btn_GrupEkle.Location = new System.Drawing.Point(227, 141);
            this.btn_GrupEkle.Name = "btn_GrupEkle";
            this.btn_GrupEkle.Size = new System.Drawing.Size(136, 45);
            this.btn_GrupEkle.TabIndex = 2;
            this.btn_GrupEkle.Text = "Ekle";
            this.btn_GrupEkle.UseVisualStyleBackColor = true;
            this.btn_GrupEkle.Click += new System.EventHandler(this.btn_GrupEkle_Click);
            // 
            // txt_GrupAdi
            // 
            this.txt_GrupAdi.Location = new System.Drawing.Point(145, 63);
            this.txt_GrupAdi.Name = "txt_GrupAdi";
            this.txt_GrupAdi.Size = new System.Drawing.Size(218, 35);
            this.txt_GrupAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grup Adı:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(282, 253);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(62, 49);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Location = new System.Drawing.Point(350, 253);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(124, 49);
            this.btn_Duzenle.TabIndex = 3;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // GrupListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 314);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.grp_EkleDuzenle);
            this.Controls.Add(this.lst_GrupListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "GrupListe";
            this.Text = "Gruplar";
            this.Load += new System.EventHandler(this.GrupListe_Load);
            this.grp_EkleDuzenle.ResumeLayout(false);
            this.grp_EkleDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_GrupListe;
        private System.Windows.Forms.GroupBox grp_EkleDuzenle;
        private System.Windows.Forms.TextBox txt_GrupAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GrupEkle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Duzenle;
    }
}