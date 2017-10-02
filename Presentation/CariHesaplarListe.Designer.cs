namespace Presentation
{
    partial class CariHesaplarListe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Cari = new System.Windows.Forms.TextBox();
            this.btn_CariAra = new System.Windows.Forms.Button();
            this.btn_YeniCari = new System.Windows.Forms.Button();
            this.btn_YeniHesapHareketi = new System.Windows.Forms.Button();
            this.btn_CariSil = new System.Windows.Forms.Button();
            this.btn_HesapHareketleri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CariDuzenle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txt_Cari
            // 
            this.txt_Cari.Location = new System.Drawing.Point(13, 37);
            this.txt_Cari.Margin = new System.Windows.Forms.Padding(7);
            this.txt_Cari.Name = "txt_Cari";
            this.txt_Cari.Size = new System.Drawing.Size(228, 35);
            this.txt_Cari.TabIndex = 1;
            // 
            // btn_CariAra
            // 
            this.btn_CariAra.Location = new System.Drawing.Point(251, 35);
            this.btn_CariAra.Name = "btn_CariAra";
            this.btn_CariAra.Size = new System.Drawing.Size(63, 39);
            this.btn_CariAra.TabIndex = 2;
            this.btn_CariAra.Text = "Ara";
            this.btn_CariAra.UseVisualStyleBackColor = true;
            this.btn_CariAra.Click += new System.EventHandler(this.btn_CariAra_Click);
            // 
            // btn_YeniCari
            // 
            this.btn_YeniCari.Location = new System.Drawing.Point(320, 35);
            this.btn_YeniCari.Name = "btn_YeniCari";
            this.btn_YeniCari.Size = new System.Drawing.Size(140, 39);
            this.btn_YeniCari.TabIndex = 3;
            this.btn_YeniCari.Text = "Yeni Cari";
            this.btn_YeniCari.UseVisualStyleBackColor = true;
            this.btn_YeniCari.Click += new System.EventHandler(this.btn_YeniCari_Click);
            // 
            // btn_YeniHesapHareketi
            // 
            this.btn_YeniHesapHareketi.Location = new System.Drawing.Point(683, 33);
            this.btn_YeniHesapHareketi.Name = "btn_YeniHesapHareketi";
            this.btn_YeniHesapHareketi.Size = new System.Drawing.Size(173, 39);
            this.btn_YeniHesapHareketi.TabIndex = 4;
            this.btn_YeniHesapHareketi.Text = "Yeni Hareket";
            this.btn_YeniHesapHareketi.UseVisualStyleBackColor = true;
            this.btn_YeniHesapHareketi.Click += new System.EventHandler(this.btn_YeniHesapHareketi_Click);
            // 
            // btn_CariSil
            // 
            this.btn_CariSil.Location = new System.Drawing.Point(466, 35);
            this.btn_CariSil.Name = "btn_CariSil";
            this.btn_CariSil.Size = new System.Drawing.Size(58, 39);
            this.btn_CariSil.TabIndex = 5;
            this.btn_CariSil.Text = "Sil";
            this.btn_CariSil.UseVisualStyleBackColor = true;
            this.btn_CariSil.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_HesapHareketleri
            // 
            this.btn_HesapHareketleri.Location = new System.Drawing.Point(862, 33);
            this.btn_HesapHareketleri.Name = "btn_HesapHareketleri";
            this.btn_HesapHareketleri.Size = new System.Drawing.Size(142, 39);
            this.btn_HesapHareketleri.TabIndex = 6;
            this.btn_HesapHareketleri.Text = "Hareketler";
            this.btn_HesapHareketleri.UseVisualStyleBackColor = true;
            this.btn_HesapHareketleri.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CariDuzenle);
            this.panel1.Controls.Add(this.txt_Cari);
            this.panel1.Controls.Add(this.btn_HesapHareketleri);
            this.panel1.Controls.Add(this.btn_CariAra);
            this.panel1.Controls.Add(this.btn_CariSil);
            this.panel1.Controls.Add(this.btn_YeniCari);
            this.panel1.Controls.Add(this.btn_YeniHesapHareketi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 94);
            this.panel1.TabIndex = 7;
            // 
            // btn_CariDuzenle
            // 
            this.btn_CariDuzenle.Location = new System.Drawing.Point(530, 35);
            this.btn_CariDuzenle.Name = "btn_CariDuzenle";
            this.btn_CariDuzenle.Size = new System.Drawing.Size(119, 39);
            this.btn_CariDuzenle.TabIndex = 7;
            this.btn_CariDuzenle.Text = "Düzenle";
            this.btn_CariDuzenle.UseVisualStyleBackColor = true;
            this.btn_CariDuzenle.Click += new System.EventHandler(this.btn_CariDuzenle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 353);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(302, 17);
            this.toolStripStatusLabel1.Text = "Cari hesaba ait hesap hareketleri için hesaba çift tıklayın.";
            // 
            // CariHesaplarListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CariHesaplarListe";
            this.Text = "Cari Hesaplar Listesi";
            this.Load += new System.EventHandler(this.CariHesaplarListe_Load);
            this.Resize += new System.EventHandler(this.CariHesaplarListe_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Cari;
        private System.Windows.Forms.Button btn_CariAra;
        private System.Windows.Forms.Button btn_YeniCari;
        private System.Windows.Forms.Button btn_YeniHesapHareketi;
        private System.Windows.Forms.Button btn_CariSil;
        private System.Windows.Forms.Button btn_HesapHareketleri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_CariDuzenle;
    }
}