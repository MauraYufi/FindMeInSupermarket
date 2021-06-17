
namespace FindMeInSupermarket
{
    partial class ProductInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.tbMerk = new System.Windows.Forms.TextBox();
            this.tbUkuran = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbDiskon = new System.Windows.Forms.TextBox();
            this.tbLokasi = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Merk :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ukuran :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diskon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lokasi Rak :";
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(119, 36);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(223, 26);
            this.tbKategori.TabIndex = 6;
            // 
            // tbMerk
            // 
            this.tbMerk.Location = new System.Drawing.Point(119, 78);
            this.tbMerk.Name = "tbMerk";
            this.tbMerk.Size = new System.Drawing.Size(223, 26);
            this.tbMerk.TabIndex = 7;
            // 
            // tbUkuran
            // 
            this.tbUkuran.Location = new System.Drawing.Point(119, 121);
            this.tbUkuran.Name = "tbUkuran";
            this.tbUkuran.Size = new System.Drawing.Size(223, 26);
            this.tbUkuran.TabIndex = 8;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(119, 161);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(223, 26);
            this.tbHarga.TabIndex = 9;
            // 
            // tbDiskon
            // 
            this.tbDiskon.Location = new System.Drawing.Point(119, 201);
            this.tbDiskon.Name = "tbDiskon";
            this.tbDiskon.Size = new System.Drawing.Size(223, 26);
            this.tbDiskon.TabIndex = 10;
            // 
            // tbLokasi
            // 
            this.tbLokasi.Location = new System.Drawing.Point(119, 238);
            this.tbLokasi.Name = "tbLokasi";
            this.tbLokasi.Size = new System.Drawing.Size(223, 26);
            this.tbLokasi.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(20, 290);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(322, 33);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Tambah Produk";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ProductInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 353);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbLokasi);
            this.Controls.Add(this.tbDiskon);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbUkuran);
            this.Controls.Add(this.tbMerk);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductInputForm";
            this.Text = "Form Input Produk";
            this.Load += new System.EventHandler(this.ProductInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.TextBox tbMerk;
        private System.Windows.Forms.TextBox tbUkuran;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbDiskon;
        private System.Windows.Forms.TextBox tbLokasi;
        private System.Windows.Forms.Button btnInsert;
    }
}