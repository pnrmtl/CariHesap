namespace Presentation
{
    partial class YedektenYukle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_silAktar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rd_Aktar = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yükleme tercihinizi seçiniz:";
            // 
            // rd_silAktar
            // 
            this.rd_silAktar.AutoSize = true;
            this.rd_silAktar.Checked = true;
            this.rd_silAktar.Location = new System.Drawing.Point(40, 78);
            this.rd_silAktar.Name = "rd_silAktar";
            this.rd_silAktar.Size = new System.Drawing.Size(508, 33);
            this.rd_silAktar.TabIndex = 1;
            this.rd_silAktar.TabStop = true;
            this.rd_silAktar.Text = "Var olan tüm kayıtları sil ve yedekten aktar";
            this.toolTip1.SetToolTip(this.rd_silAktar, "Programda daha önce kaydettiğiniz tüm kayıtları siler. Yedekten yüklenen kayıtlar" +
        "la çalışmanızı sağlar. Son yedeğinizi alıp farklı bir bilgisayara aktarmak istiy" +
        "orsanız bu seçeneği seçebilirsiniz.");
            this.rd_silAktar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rd_Aktar
            // 
            this.rd_Aktar.AutoSize = true;
            this.rd_Aktar.Location = new System.Drawing.Point(40, 130);
            this.rd_Aktar.Name = "rd_Aktar";
            this.rd_Aktar.Size = new System.Drawing.Size(385, 33);
            this.rd_Aktar.TabIndex = 3;
            this.rd_Aktar.Text = "Kayıtları koru ve yedekten aktar";
            this.toolTip1.SetToolTip(this.rd_Aktar, "Var olan kayıtları silmeden yedekten gelen tüm bilgileri üzerine ekler.");
            this.rd_Aktar.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Yedekten Yükle";
            // 
            // YedektenYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 267);
            this.Controls.Add(this.rd_Aktar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_silAktar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "YedektenYukle";
            this.Text = "Yedekten Yukle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_silAktar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rd_Aktar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}