
namespace Hotel_Harem_SamGun
{
    partial class FormMenuAdmin
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
            this.btDataResepsionis = new System.Windows.Forms.Button();
            this.btDataMenuMakanan = new System.Windows.Forms.Button();
            this.btDataKamar = new System.Windows.Forms.Button();
            this.btDataFasilitasTambahanKamar = new System.Windows.Forms.Button();
            this.btLaporan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDataResepsionis
            // 
            this.btDataResepsionis.Location = new System.Drawing.Point(12, 12);
            this.btDataResepsionis.Name = "btDataResepsionis";
            this.btDataResepsionis.Size = new System.Drawing.Size(199, 87);
            this.btDataResepsionis.TabIndex = 0;
            this.btDataResepsionis.Text = "DATA RESEPSIONIS";
            this.btDataResepsionis.UseVisualStyleBackColor = true;
            this.btDataResepsionis.Click += new System.EventHandler(this.btDataResepsionis_Click);
            // 
            // btDataMenuMakanan
            // 
            this.btDataMenuMakanan.Location = new System.Drawing.Point(12, 105);
            this.btDataMenuMakanan.Name = "btDataMenuMakanan";
            this.btDataMenuMakanan.Size = new System.Drawing.Size(199, 87);
            this.btDataMenuMakanan.TabIndex = 1;
            this.btDataMenuMakanan.Text = "DATA MENU MAKANAN";
            this.btDataMenuMakanan.UseVisualStyleBackColor = true;
            this.btDataMenuMakanan.Click += new System.EventHandler(this.btDataMenuMakanan_Click);
            // 
            // btDataKamar
            // 
            this.btDataKamar.Location = new System.Drawing.Point(12, 198);
            this.btDataKamar.Name = "btDataKamar";
            this.btDataKamar.Size = new System.Drawing.Size(199, 87);
            this.btDataKamar.TabIndex = 2;
            this.btDataKamar.Text = "DATA KAMAR";
            this.btDataKamar.UseVisualStyleBackColor = true;
            this.btDataKamar.Click += new System.EventHandler(this.btDataKamar_Click);
            // 
            // btDataFasilitasTambahanKamar
            // 
            this.btDataFasilitasTambahanKamar.Location = new System.Drawing.Point(12, 291);
            this.btDataFasilitasTambahanKamar.Name = "btDataFasilitasTambahanKamar";
            this.btDataFasilitasTambahanKamar.Size = new System.Drawing.Size(199, 87);
            this.btDataFasilitasTambahanKamar.TabIndex = 3;
            this.btDataFasilitasTambahanKamar.Text = "DATA FASILITAS TAMBAHAN KAMAR";
            this.btDataFasilitasTambahanKamar.UseVisualStyleBackColor = true;
            this.btDataFasilitasTambahanKamar.Click += new System.EventHandler(this.btDataFasilitasTambahanKamar_Click);
            // 
            // btLaporan
            // 
            this.btLaporan.Location = new System.Drawing.Point(12, 384);
            this.btLaporan.Name = "btLaporan";
            this.btLaporan.Size = new System.Drawing.Size(199, 87);
            this.btLaporan.TabIndex = 4;
            this.btLaporan.Text = "LAPORAN";
            this.btLaporan.UseVisualStyleBackColor = true;
            this.btLaporan.Click += new System.EventHandler(this.btLaporan_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btLaporan);
            this.Controls.Add(this.btDataFasilitasTambahanKamar);
            this.Controls.Add(this.btDataKamar);
            this.Controls.Add(this.btDataMenuMakanan);
            this.Controls.Add(this.btDataResepsionis);
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Menu Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDataResepsionis;
        private System.Windows.Forms.Button btDataMenuMakanan;
        private System.Windows.Forms.Button btDataKamar;
        private System.Windows.Forms.Button btDataFasilitasTambahanKamar;
        private System.Windows.Forms.Button btLaporan;
    }
}