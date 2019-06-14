namespace OnlisansProje
{
    partial class Kişi_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kişi_Ekle));
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.txtAdEkle = new System.Windows.Forms.TextBox();
            this.txtSoyEkle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelEkle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(87, 348);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(100, 23);
            this.btnKisiEkle.TabIndex = 6;
            this.btnKisiEkle.Text = "Kişi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // txtAdEkle
            // 
            this.txtAdEkle.Location = new System.Drawing.Point(87, 164);
            this.txtAdEkle.Name = "txtAdEkle";
            this.txtAdEkle.Size = new System.Drawing.Size(100, 20);
            this.txtAdEkle.TabIndex = 1;
            this.txtAdEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdEkle_KeyPress);
            // 
            // txtSoyEkle
            // 
            this.txtSoyEkle.Location = new System.Drawing.Point(87, 190);
            this.txtSoyEkle.Name = "txtSoyEkle";
            this.txtSoyEkle.Size = new System.Drawing.Size(100, 20);
            this.txtSoyEkle.TabIndex = 2;
            this.txtSoyEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyEkle_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon :";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(87, 115);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(100, 24);
            this.btnResimEkle.TabIndex = 0;
            this.btnResimEkle.Text = "Avatar Seç";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(87, 377);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 23);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-Mail :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(87, 268);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(129, 60);
            this.txtAdres.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Adres :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(194, 348);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(23, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblTel
            // 
            this.lblTel.BackColor = System.Drawing.Color.White;
            this.lblTel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTel.Location = new System.Drawing.Point(89, 218);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(96, 16);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "0533 333 33 33 ";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTel_MouseMove);
            // 
            // txtTelEkle
            // 
            this.txtTelEkle.Location = new System.Drawing.Point(87, 216);
            this.txtTelEkle.MaxLength = 11;
            this.txtTelEkle.Name = "txtTelEkle";
            this.txtTelEkle.Size = new System.Drawing.Size(100, 20);
            this.txtTelEkle.TabIndex = 3;
            this.txtTelEkle.Enter += new System.EventHandler(this.txtTelEkle_Enter);
            this.txtTelEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelEkle_KeyPress);
            this.txtTelEkle.Leave += new System.EventHandler(this.txtTelEkle_Leave_1);
            // 
            // Kişi_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyEkle);
            this.Controls.Add(this.txtAdEkle);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTelEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kişi_Ekle";
            this.Text = "Kişi_Ekle";
            this.Load += new System.EventHandler(this.Kişi_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.TextBox txtAdEkle;
        private System.Windows.Forms.TextBox txtSoyEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelEkle;
    }
}