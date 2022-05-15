
namespace Hotel_Harem_SamGun
{
    partial class FormDataMenuMakanan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbJenisMakanan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTidakTersedia = new System.Windows.Forms.RadioButton();
            this.rbTersedia = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATA MENU MAKANAN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbJenisMakanan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbStok);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbHarga);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbKode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1625, 392);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cbJenisMakanan
            // 
            this.cbJenisMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJenisMakanan.FormattingEnabled = true;
            this.cbJenisMakanan.Location = new System.Drawing.Point(213, 338);
            this.cbJenisMakanan.Name = "cbJenisMakanan";
            this.cbJenisMakanan.Size = new System.Drawing.Size(400, 33);
            this.cbJenisMakanan.TabIndex = 11;
            this.cbJenisMakanan.SelectedIndexChanged += new System.EventHandler(this.cbJenisMakanan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jenis Makanan";
            // 
            // tbStok
            // 
            this.tbStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStok.Location = new System.Drawing.Point(216, 213);
            this.tbStok.Margin = new System.Windows.Forms.Padding(4);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(397, 30);
            this.tbStok.TabIndex = 9;
            this.tbStok.TextChanged += new System.EventHandler(this.tbStok_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stok Makanan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbTidakTersedia);
            this.panel1.Controls.Add(this.rbTersedia);
            this.panel1.Location = new System.Drawing.Point(213, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 54);
            this.panel1.TabIndex = 7;
            // 
            // rbTidakTersedia
            // 
            this.rbTidakTersedia.AutoSize = true;
            this.rbTidakTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTidakTersedia.Location = new System.Drawing.Point(137, 12);
            this.rbTidakTersedia.Name = "rbTidakTersedia";
            this.rbTidakTersedia.Size = new System.Drawing.Size(164, 29);
            this.rbTidakTersedia.TabIndex = 1;
            this.rbTidakTersedia.Text = "Tidak Tersedia";
            this.rbTidakTersedia.UseVisualStyleBackColor = true;
            this.rbTidakTersedia.CheckedChanged += new System.EventHandler(this.rbTidakTersedia_CheckedChanged);
            // 
            // rbTersedia
            // 
            this.rbTersedia.AutoSize = true;
            this.rbTersedia.Checked = true;
            this.rbTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTersedia.Location = new System.Drawing.Point(3, 12);
            this.rbTersedia.Name = "rbTersedia";
            this.rbTersedia.Size = new System.Drawing.Size(110, 29);
            this.rbTersedia.TabIndex = 0;
            this.rbTersedia.TabStop = true;
            this.rbTersedia.Text = "Tersedia";
            this.rbTersedia.UseVisualStyleBackColor = true;
            this.rbTersedia.CheckedChanged += new System.EventHandler(this.rbTersedia_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status Makanan";
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(216, 153);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(397, 30);
            this.tbHarga.TabIndex = 5;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga Makanan";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(216, 91);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(397, 30);
            this.tbNama.TabIndex = 3;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Makanan";
            // 
            // tbKode
            // 
            this.tbKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKode.Location = new System.Drawing.Point(216, 31);
            this.tbKode.Margin = new System.Windows.Forms.Padding(4);
            this.tbKode.Name = "tbKode";
            this.tbKode.ReadOnly = true;
            this.tbKode.Size = new System.Drawing.Size(397, 30);
            this.tbKode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Makanan";
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(30, 455);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(157, 53);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 530);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1625, 281);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Enabled = false;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(211, 455);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(157, 53);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(395, 455);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 53);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "UBAH";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBersihkan.Location = new System.Drawing.Point(583, 455);
            this.btnBersihkan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(157, 53);
            this.btnBersihkan.TabIndex = 11;
            this.btnBersihkan.Text = "BERSIHKAN";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // FormDataMenuMakanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 847);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDataMenuMakanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDataMenuMakanan";
            this.Load += new System.EventHandler(this.FormDataMenuMakanan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTidakTersedia;
        private System.Windows.Forms.RadioButton rbTersedia;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.ComboBox cbJenisMakanan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Label label6;
    }
}