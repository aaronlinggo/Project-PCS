
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDataResepsionis
            // 
            this.btDataResepsionis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataResepsionis.Location = new System.Drawing.Point(371, 17);
            this.btDataResepsionis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDataResepsionis.Name = "btDataResepsionis";
            this.btDataResepsionis.Size = new System.Drawing.Size(400, 68);
            this.btDataResepsionis.TabIndex = 0;
            this.btDataResepsionis.Text = "DATA RESEPSIONIS";
            this.btDataResepsionis.UseVisualStyleBackColor = true;
            this.btDataResepsionis.Click += new System.EventHandler(this.btDataResepsionis_Click);
            // 
            // btDataMenuMakanan
            // 
            this.btDataMenuMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataMenuMakanan.Location = new System.Drawing.Point(371, 95);
            this.btDataMenuMakanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDataMenuMakanan.Name = "btDataMenuMakanan";
            this.btDataMenuMakanan.Size = new System.Drawing.Size(400, 68);
            this.btDataMenuMakanan.TabIndex = 1;
            this.btDataMenuMakanan.Text = "DATA MENU MAKANAN";
            this.btDataMenuMakanan.UseVisualStyleBackColor = true;
            this.btDataMenuMakanan.Click += new System.EventHandler(this.btDataMenuMakanan_Click);
            // 
            // btDataKamar
            // 
            this.btDataKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataKamar.Location = new System.Drawing.Point(371, 173);
            this.btDataKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDataKamar.Name = "btDataKamar";
            this.btDataKamar.Size = new System.Drawing.Size(400, 68);
            this.btDataKamar.TabIndex = 2;
            this.btDataKamar.Text = "DATA KAMAR";
            this.btDataKamar.UseVisualStyleBackColor = true;
            this.btDataKamar.Click += new System.EventHandler(this.btDataKamar_Click);
            // 
            // btDataFasilitasTambahanKamar
            // 
            this.btDataFasilitasTambahanKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataFasilitasTambahanKamar.Location = new System.Drawing.Point(371, 251);
            this.btDataFasilitasTambahanKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDataFasilitasTambahanKamar.Name = "btDataFasilitasTambahanKamar";
            this.btDataFasilitasTambahanKamar.Size = new System.Drawing.Size(400, 68);
            this.btDataFasilitasTambahanKamar.TabIndex = 3;
            this.btDataFasilitasTambahanKamar.Text = "DATA TAMBAHAN FASILITAS KAMAR";
            this.btDataFasilitasTambahanKamar.UseVisualStyleBackColor = true;
            this.btDataFasilitasTambahanKamar.Click += new System.EventHandler(this.btDataFasilitasTambahanKamar_Click);
            // 
            // btLaporan
            // 
            this.btLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLaporan.Location = new System.Drawing.Point(371, 329);
            this.btLaporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLaporan.Name = "btLaporan";
            this.btLaporan.Size = new System.Drawing.Size(400, 68);
            this.btLaporan.TabIndex = 4;
            this.btLaporan.Text = "LAPORAN";
            this.btLaporan.UseVisualStyleBackColor = true;
            this.btLaporan.Click += new System.EventHandler(this.btLaporan_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(12, 17);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(352, 380);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Text = "Welcome,\r\nNama Admin!";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(21, 350);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 47);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.btLaporan);
            this.Controls.Add(this.btDataFasilitasTambahanKamar);
            this.Controls.Add(this.btDataKamar);
            this.Controls.Add(this.btDataMenuMakanan);
            this.Controls.Add(this.btDataResepsionis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Menu Admin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDataResepsionis;
        private System.Windows.Forms.Button btDataMenuMakanan;
        private System.Windows.Forms.Button btDataKamar;
        private System.Windows.Forms.Button btDataFasilitasTambahanKamar;
        private System.Windows.Forms.Button btLaporan;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnLogout;
    }
}