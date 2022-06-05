namespace Hotel_Harem_SamGun
{
    partial class FormReservasi
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
            this.dgvHeaderReservasi = new System.Windows.Forms.DataGridView();
            this.btBuatReservasi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbKodeReservasi = new System.Windows.Forms.Label();
            this.cbCari = new System.Windows.Forms.ComboBox();
            this.btCari = new System.Windows.Forms.Button();
            this.btKembali = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbTotalBiayaReservasi = new System.Windows.Forms.Label();
            this.btBersihkan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNamaTamu = new System.Windows.Forms.Label();
            this.lbJumlahReservasi = new System.Windows.Forms.Label();
            this.legend0 = new System.Windows.Forms.Panel();
            this.legend1 = new System.Windows.Forms.Panel();
            this.legend99 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaderReservasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHeaderReservasi
            // 
            this.dgvHeaderReservasi.AllowUserToAddRows = false;
            this.dgvHeaderReservasi.AllowUserToDeleteRows = false;
            this.dgvHeaderReservasi.AllowUserToResizeColumns = false;
            this.dgvHeaderReservasi.AllowUserToResizeRows = false;
            this.dgvHeaderReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeaderReservasi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHeaderReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeaderReservasi.Location = new System.Drawing.Point(21, 100);
            this.dgvHeaderReservasi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvHeaderReservasi.Name = "dgvHeaderReservasi";
            this.dgvHeaderReservasi.ReadOnly = true;
            this.dgvHeaderReservasi.RowHeadersVisible = false;
            this.dgvHeaderReservasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHeaderReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeaderReservasi.Size = new System.Drawing.Size(1222, 396);
            this.dgvHeaderReservasi.TabIndex = 99;
            this.dgvHeaderReservasi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeaderReservasi_CellDoubleClick);
            // 
            // btBuatReservasi
            // 
            this.btBuatReservasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuatReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuatReservasi.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuatReservasi.ForeColor = System.Drawing.Color.White;
            this.btBuatReservasi.Location = new System.Drawing.Point(965, 511);
            this.btBuatReservasi.Name = "btBuatReservasi";
            this.btBuatReservasi.Size = new System.Drawing.Size(280, 33);
            this.btBuatReservasi.TabIndex = 4;
            this.btBuatReservasi.Text = "UBAH / BUAT RESERVASI BARU";
            this.btBuatReservasi.UseVisualStyleBackColor = false;
            this.btBuatReservasi.Click += new System.EventHandler(this.btBuatReservasi_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 555);
            this.label8.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nama Tamu :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kode Reservasi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 637);
            this.label9.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total Biaya Reservasi :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbKodeReservasi
            // 
            this.lbKodeReservasi.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKodeReservasi.Location = new System.Drawing.Point(521, 514);
            this.lbKodeReservasi.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lbKodeReservasi.Name = "lbKodeReservasi";
            this.lbKodeReservasi.Size = new System.Drawing.Size(229, 26);
            this.lbKodeReservasi.TabIndex = 16;
            this.lbKodeReservasi.Text = "-";
            // 
            // cbCari
            // 
            this.cbCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCari.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCari.FormattingEnabled = true;
            this.cbCari.Location = new System.Drawing.Point(570, 55);
            this.cbCari.Name = "cbCari";
            this.cbCari.Size = new System.Drawing.Size(299, 31);
            this.cbCari.TabIndex = 1;
            // 
            // btCari
            // 
            this.btCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCari.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCari.ForeColor = System.Drawing.Color.White;
            this.btCari.Location = new System.Drawing.Point(878, 13);
            this.btCari.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(118, 33);
            this.btCari.TabIndex = 7;
            this.btCari.Text = "CARI";
            this.btCari.UseVisualStyleBackColor = false;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btKembali.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKembali.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembali.ForeColor = System.Drawing.Color.White;
            this.btKembali.Location = new System.Drawing.Point(1126, 13);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(118, 33);
            this.btKembali.TabIndex = 100;
            this.btKembali.Text = "KEMBALI";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Selesai",
            "Sedang Berlangsung",
            "Dibatalkan"});
            this.cbStatus.Location = new System.Drawing.Point(570, 14);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(299, 31);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(276, 16);
            this.label21.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(279, 26);
            this.label21.TabIndex = 101;
            this.label21.Text = "Status :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(276, 57);
            this.label22.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(279, 26);
            this.label22.TabIndex = 102;
            this.label22.Text = "Nama Tamu - Kode Reservasi :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalBiayaReservasi
            // 
            this.lbTotalBiayaReservasi.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBiayaReservasi.Location = new System.Drawing.Point(521, 637);
            this.lbTotalBiayaReservasi.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lbTotalBiayaReservasi.Name = "lbTotalBiayaReservasi";
            this.lbTotalBiayaReservasi.Size = new System.Drawing.Size(229, 26);
            this.lbTotalBiayaReservasi.TabIndex = 103;
            this.lbTotalBiayaReservasi.Text = "-";
            this.lbTotalBiayaReservasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btBersihkan
            // 
            this.btBersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBersihkan.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBersihkan.ForeColor = System.Drawing.Color.White;
            this.btBersihkan.Location = new System.Drawing.Point(1002, 13);
            this.btBersihkan.Name = "btBersihkan";
            this.btBersihkan.Size = new System.Drawing.Size(118, 33);
            this.btBersihkan.TabIndex = 6;
            this.btBersihkan.Text = "BERSIHKAN";
            this.btBersihkan.UseVisualStyleBackColor = false;
            this.btBersihkan.Click += new System.EventHandler(this.btBersihkan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 38);
            this.label7.TabIndex = 136;
            this.label7.Text = "HEADER RESERVASI";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 596);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 26);
            this.label6.TabIndex = 137;
            this.label6.Text = "Jumlah Reservasi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNamaTamu
            // 
            this.lbNamaTamu.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamaTamu.Location = new System.Drawing.Point(521, 555);
            this.lbNamaTamu.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lbNamaTamu.Name = "lbNamaTamu";
            this.lbNamaTamu.Size = new System.Drawing.Size(229, 26);
            this.lbNamaTamu.TabIndex = 139;
            this.lbNamaTamu.Text = "-";
            // 
            // lbJumlahReservasi
            // 
            this.lbJumlahReservasi.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahReservasi.Location = new System.Drawing.Point(521, 596);
            this.lbJumlahReservasi.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lbJumlahReservasi.Name = "lbJumlahReservasi";
            this.lbJumlahReservasi.Size = new System.Drawing.Size(229, 26);
            this.lbJumlahReservasi.TabIndex = 140;
            this.lbJumlahReservasi.Text = "-";
            // 
            // legend0
            // 
            this.legend0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend0.Location = new System.Drawing.Point(21, 511);
            this.legend0.Name = "legend0";
            this.legend0.Size = new System.Drawing.Size(20, 20);
            this.legend0.TabIndex = 141;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.LightGreen;
            this.legend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend1.Location = new System.Drawing.Point(21, 537);
            this.legend1.Name = "legend1";
            this.legend1.Size = new System.Drawing.Size(20, 20);
            this.legend1.TabIndex = 142;
            // 
            // legend99
            // 
            this.legend99.BackColor = System.Drawing.Color.DarkGray;
            this.legend99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend99.Location = new System.Drawing.Point(21, 563);
            this.legend99.Name = "legend99";
            this.legend99.Size = new System.Drawing.Size(20, 20);
            this.legend99.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 144;
            this.label1.Text = "Selesai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 145;
            this.label2.Text = "Sedang Berlangsung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 146;
            this.label3.Text = "Dibatalkan";
            // 
            // FormReservasi
            // 
            this.AcceptButton = this.btBuatReservasi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btKembali;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legend99);
            this.Controls.Add(this.legend1);
            this.Controls.Add(this.legend0);
            this.Controls.Add(this.lbJumlahReservasi);
            this.Controls.Add(this.lbNamaTamu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btBersihkan);
            this.Controls.Add(this.lbTotalBiayaReservasi);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btCari);
            this.Controls.Add(this.cbCari);
            this.Controls.Add(this.lbKodeReservasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btBuatReservasi);
            this.Controls.Add(this.dgvHeaderReservasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReservasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservasi";
            this.Load += new System.EventHandler(this.FormReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaderReservasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHeaderReservasi;
        private System.Windows.Forms.Button btBuatReservasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbKodeReservasi;
        private System.Windows.Forms.ComboBox cbCari;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Button btKembali;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbTotalBiayaReservasi;
        private System.Windows.Forms.Button btBersihkan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNamaTamu;
        private System.Windows.Forms.Label lbJumlahReservasi;
        private System.Windows.Forms.Panel legend0;
        private System.Windows.Forms.Panel legend1;
        private System.Windows.Forms.Panel legend99;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}