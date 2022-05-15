
namespace Hotel_Harem_SamGun
{
    partial class FormDataKamar
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
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.numKamarKe = new System.Windows.Forms.NumericUpDown();
            this.numLantai = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboJenisKamar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNoKamar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKamarKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLantai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKamar
            // 
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamar.Location = new System.Drawing.Point(24, 71);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersVisible = false;
            this.dgvKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKamar.Size = new System.Drawing.Size(1219, 308);
            this.dgvKamar.TabIndex = 0;
            this.dgvKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(24, 617);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(118, 43);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(1016, 617);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(105, 43);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATA KAMAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rb0);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numKamarKe);
            this.groupBox1.Controls.Add(this.numLantai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboJenisKamar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNoKamar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbKode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(153, 19);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(126, 26);
            this.tbID.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb0.Location = new System.Drawing.Point(928, 133);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(130, 24);
            this.rb0.TabIndex = 15;
            this.rb0.TabStop = true;
            this.rb0.Text = "Tidak Tersedia";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb1.Location = new System.Drawing.Point(812, 133);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(88, 24);
            this.rb1.TabIndex = 14;
            this.rb1.TabStop = true;
            this.rb1.Text = "Tersedia";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(659, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status";
            // 
            // numKamarKe
            // 
            this.numKamarKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numKamarKe.Location = new System.Drawing.Point(812, 77);
            this.numKamarKe.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numKamarKe.Name = "numKamarKe";
            this.numKamarKe.Size = new System.Drawing.Size(91, 26);
            this.numKamarKe.TabIndex = 12;
            this.numKamarKe.ValueChanged += new System.EventHandler(this.numNoKamar_ValueChanged);
            // 
            // numLantai
            // 
            this.numLantai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numLantai.Location = new System.Drawing.Point(812, 31);
            this.numLantai.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numLantai.Name = "numLantai";
            this.numLantai.Size = new System.Drawing.Size(91, 26);
            this.numLantai.TabIndex = 11;
            this.numLantai.ValueChanged += new System.EventHandler(this.numLantai_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kamar ke-";
            // 
            // comboJenisKamar
            // 
            this.comboJenisKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboJenisKamar.FormattingEnabled = true;
            this.comboJenisKamar.Location = new System.Drawing.Point(153, 165);
            this.comboJenisKamar.Name = "comboJenisKamar";
            this.comboJenisKamar.Size = new System.Drawing.Size(164, 28);
            this.comboJenisKamar.TabIndex = 9;
            this.comboJenisKamar.SelectedIndexChanged += new System.EventHandler(this.comboJenisKamar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lantai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jenis";
            // 
            // tbNoKamar
            // 
            this.tbNoKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoKamar.Location = new System.Drawing.Point(153, 109);
            this.tbNoKamar.Name = "tbNoKamar";
            this.tbNoKamar.ReadOnly = true;
            this.tbNoKamar.Size = new System.Drawing.Size(164, 26);
            this.tbNoKamar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Kamar";
            // 
            // tbKode
            // 
            this.tbKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKode.Location = new System.Drawing.Point(153, 60);
            this.tbKode.Name = "tbKode";
            this.tbKode.ReadOnly = true;
            this.tbKode.Size = new System.Drawing.Size(126, 26);
            this.tbKode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode";
            // 
            // btnUbah
            // 
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(1138, 617);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(105, 43);
            this.btnUbah.TabIndex = 6;
            this.btnUbah.Text = "UBAH";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBersihkan.Location = new System.Drawing.Point(163, 617);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(118, 43);
            this.btnBersihkan.TabIndex = 7;
            this.btnBersihkan.Text = "BERSIHKAN";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(1138, 22);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(105, 43);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // FormDataKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgvKamar);
            this.Name = "FormDataKamar";
            this.Text = "Data Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKamarKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLantai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNoKamar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.NumericUpDown numKamarKe;
        private System.Windows.Forms.NumericUpDown numLantai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboJenisKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKembali;
    }
}