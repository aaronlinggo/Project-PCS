﻿namespace Hotel_Harem_SamGun
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservasi = new System.Windows.Forms.DataGridView();
            this.btReservasi = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbKodeReservasi = new System.Windows.Forms.Label();
            this.lbTotalTarifKamar = new System.Windows.Forms.Label();
            this.lbKodeKaryawan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Check In :";
            // 
            // dgvReservasi
            // 
            this.dgvReservasi.AllowUserToAddRows = false;
            this.dgvReservasi.AllowUserToDeleteRows = false;
            this.dgvReservasi.AllowUserToResizeColumns = false;
            this.dgvReservasi.AllowUserToResizeRows = false;
            this.dgvReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasi.Location = new System.Drawing.Point(13, 14);
            this.dgvReservasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservasi.Name = "dgvReservasi";
            this.dgvReservasi.ReadOnly = true;
            this.dgvReservasi.RowHeadersVisible = false;
            this.dgvReservasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservasi.Size = new System.Drawing.Size(1238, 347);
            this.dgvReservasi.TabIndex = 1;
            // 
            // btReservasi
            // 
            this.btReservasi.Location = new System.Drawing.Point(953, 422);
            this.btReservasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btReservasi.Name = "btReservasi";
            this.btReservasi.Size = new System.Drawing.Size(214, 50);
            this.btReservasi.TabIndex = 2;
            this.btReservasi.Text = "RESERVASI";
            this.btReservasi.UseVisualStyleBackColor = true;
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(953, 540);
            this.btBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(214, 49);
            this.btBatal.TabIndex = 3;
            this.btBatal.Text = "BATAL";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(164, 467);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(298, 26);
            this.dtpCheckIn.TabIndex = 4;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(164, 505);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(298, 26);
            this.dtpCheckOut.TabIndex = 5;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 510);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tanggal Check Out :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama Tamu :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 423);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 26);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kode Kamar :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(667, 395);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kode Reservasi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 627);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kode Karyawan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 437);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Tarif Kamar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 590);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Deposito :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 560);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Down Payment :";
            // 
            // lbKodeReservasi
            // 
            this.lbKodeReservasi.AutoSize = true;
            this.lbKodeReservasi.Location = new System.Drawing.Point(149, 376);
            this.lbKodeReservasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKodeReservasi.Name = "lbKodeReservasi";
            this.lbKodeReservasi.Size = new System.Drawing.Size(14, 20);
            this.lbKodeReservasi.TabIndex = 16;
            this.lbKodeReservasi.Text = "-";
            // 
            // lbTotalTarifKamar
            // 
            this.lbTotalTarifKamar.AutoSize = true;
            this.lbTotalTarifKamar.Location = new System.Drawing.Point(653, 437);
            this.lbTotalTarifKamar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalTarifKamar.Name = "lbTotalTarifKamar";
            this.lbTotalTarifKamar.Size = new System.Drawing.Size(43, 20);
            this.lbTotalTarifKamar.TabIndex = 17;
            this.lbTotalTarifKamar.Text = "Rp 0";
            // 
            // lbKodeKaryawan
            // 
            this.lbKodeKaryawan.AutoSize = true;
            this.lbKodeKaryawan.Location = new System.Drawing.Point(149, 627);
            this.lbKodeKaryawan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKodeKaryawan.Name = "lbKodeKaryawan";
            this.lbKodeKaryawan.Size = new System.Drawing.Size(14, 20);
            this.lbKodeKaryawan.TabIndex = 18;
            this.lbKodeKaryawan.Text = "-";
            // 
            // FormReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbKodeKaryawan);
            this.Controls.Add(this.lbTotalTarifKamar);
            this.Controls.Add(this.lbKodeReservasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btReservasi);
            this.Controls.Add(this.dgvReservasi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReservasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Reservasi";
            this.Load += new System.EventHandler(this.FormReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservasi;
        private System.Windows.Forms.Button btReservasi;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbKodeReservasi;
        private System.Windows.Forms.Label lbTotalTarifKamar;
        private System.Windows.Forms.Label lbKodeKaryawan;
    }
}