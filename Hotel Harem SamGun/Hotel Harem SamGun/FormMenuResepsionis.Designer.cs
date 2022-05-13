
namespace Hotel_Harem_SamGun
{
    partial class FormMenuResepsionis
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
            this.btReservasi = new System.Windows.Forms.Button();
            this.btPenambahanFasilitasKamar = new System.Windows.Forms.Button();
            this.btPemesananMakanan = new System.Windows.Forms.Button();
            this.btCheckInCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReservasi
            // 
            this.btReservasi.Location = new System.Drawing.Point(12, 12);
            this.btReservasi.Name = "btReservasi";
            this.btReservasi.Size = new System.Drawing.Size(139, 54);
            this.btReservasi.TabIndex = 0;
            this.btReservasi.Text = "RESERVASI";
            this.btReservasi.UseVisualStyleBackColor = true;
            this.btReservasi.Click += new System.EventHandler(this.btReservasi_Click);
            // 
            // btPenambahanFasilitasKamar
            // 
            this.btPenambahanFasilitasKamar.Location = new System.Drawing.Point(12, 72);
            this.btPenambahanFasilitasKamar.Name = "btPenambahanFasilitasKamar";
            this.btPenambahanFasilitasKamar.Size = new System.Drawing.Size(139, 54);
            this.btPenambahanFasilitasKamar.TabIndex = 1;
            this.btPenambahanFasilitasKamar.Text = "PENAMBAHAN FASILITAS KAMAR";
            this.btPenambahanFasilitasKamar.UseVisualStyleBackColor = true;
            this.btPenambahanFasilitasKamar.Click += new System.EventHandler(this.btPenambahanFasilitasKamar_Click);
            // 
            // btPemesananMakanan
            // 
            this.btPemesananMakanan.Location = new System.Drawing.Point(12, 132);
            this.btPemesananMakanan.Name = "btPemesananMakanan";
            this.btPemesananMakanan.Size = new System.Drawing.Size(139, 54);
            this.btPemesananMakanan.TabIndex = 2;
            this.btPemesananMakanan.Text = "PEMESANAN MAKANAN";
            this.btPemesananMakanan.UseVisualStyleBackColor = true;
            this.btPemesananMakanan.Click += new System.EventHandler(this.btPemesananMakanan_Click);
            // 
            // btCheckInCheckOut
            // 
            this.btCheckInCheckOut.Location = new System.Drawing.Point(12, 192);
            this.btCheckInCheckOut.Name = "btCheckInCheckOut";
            this.btCheckInCheckOut.Size = new System.Drawing.Size(139, 54);
            this.btCheckInCheckOut.TabIndex = 3;
            this.btCheckInCheckOut.Text = "CHECK IN\r\nCHECK OUT";
            this.btCheckInCheckOut.UseVisualStyleBackColor = true;
            this.btCheckInCheckOut.Click += new System.EventHandler(this.btCheckInCheckOut_Click);
            // 
            // FormMenuResepsionis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btCheckInCheckOut);
            this.Controls.Add(this.btPemesananMakanan);
            this.Controls.Add(this.btPenambahanFasilitasKamar);
            this.Controls.Add(this.btReservasi);
            this.Name = "FormMenuResepsionis";
            this.Text = "Form Menu Resepsionis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReservasi;
        private System.Windows.Forms.Button btPenambahanFasilitasKamar;
        private System.Windows.Forms.Button btPemesananMakanan;
        private System.Windows.Forms.Button btCheckInCheckOut;
    }
}