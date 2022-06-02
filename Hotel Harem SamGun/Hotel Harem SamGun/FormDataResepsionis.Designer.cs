
namespace Hotel_Harem_SamGun
{
    partial class FormDataResepsionis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbResepsionis = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATA RESEPSIONIS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 217);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnBersihkan.Location = new System.Drawing.Point(989, 22);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(118, 36);
            this.btnBersihkan.TabIndex = 16;
            this.btnBersihkan.Text = "BERSIHKAN";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnEdit.Location = new System.Drawing.Point(292, 322);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 43);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "UBAH";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Enabled = false;
            this.btnHapus.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnHapus.Location = new System.Drawing.Point(154, 322);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(118, 43);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnTambah.Location = new System.Drawing.Point(18, 322);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 43);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbConfirm);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbNoTelp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbKode);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbAlamat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtTanggalLahir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1225, 306);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbConfirm.Location = new System.Drawing.Point(662, 142);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '*';
            this.tbConfirm.Size = new System.Drawing.Size(299, 26);
            this.tbConfirm.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(514, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Confirm Password";
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbNoTelp.Location = new System.Drawing.Point(162, 257);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(299, 26);
            this.tbNoTelp.TabIndex = 23;
            this.tbNoTelp.TextChanged += new System.EventHandler(this.tbNoTelp_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(32, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nomor Telepon";
            // 
            // tbKode
            // 
            this.tbKode.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbKode.Location = new System.Drawing.Point(162, 64);
            this.tbKode.Name = "tbKode";
            this.tbKode.ReadOnly = true;
            this.tbKode.Size = new System.Drawing.Size(299, 26);
            this.tbKode.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(34, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kode Karyawan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbResepsionis);
            this.panel2.Controls.Add(this.rbAdmin);
            this.panel2.Location = new System.Drawing.Point(662, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 44);
            this.panel2.TabIndex = 19;
            // 
            // rbResepsionis
            // 
            this.rbResepsionis.AutoSize = true;
            this.rbResepsionis.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.rbResepsionis.Location = new System.Drawing.Point(103, 10);
            this.rbResepsionis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbResepsionis.Name = "rbResepsionis";
            this.rbResepsionis.Size = new System.Drawing.Size(105, 27);
            this.rbResepsionis.TabIndex = 1;
            this.rbResepsionis.Text = "Resepsionis";
            this.rbResepsionis.UseVisualStyleBackColor = true;
            this.rbResepsionis.CheckedChanged += new System.EventHandler(this.rbResepsionis_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.rbAdmin.Location = new System.Drawing.Point(2, 10);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(71, 27);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(604, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Roles";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbPassword.Location = new System.Drawing.Point(662, 102);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(299, 26);
            this.tbPassword.TabIndex = 17;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(574, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbEmail.Location = new System.Drawing.Point(662, 64);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(299, 26);
            this.tbEmail.TabIndex = 15;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(528, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email Karyawan";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbAlamat.Location = new System.Drawing.Point(662, 25);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(299, 26);
            this.tbAlamat.TabIndex = 13;
            this.tbAlamat.TextChanged += new System.EventHandler(this.tbNoTelp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(590, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alamat";
            // 
            // dtTanggalLahir
            // 
            this.dtTanggalLahir.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.dtTanggalLahir.Location = new System.Drawing.Point(162, 221);
            this.dtTanggalLahir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtTanggalLahir.Name = "dtTanggalLahir";
            this.dtTanggalLahir.Size = new System.Drawing.Size(299, 26);
            this.dtTanggalLahir.TabIndex = 11;
            this.dtTanggalLahir.ValueChanged += new System.EventHandler(this.dtTanggalLahir_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(49, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tanggal Lahir";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPerempuan);
            this.panel1.Controls.Add(this.rbLaki);
            this.panel1.Location = new System.Drawing.Point(162, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 44);
            this.panel1.TabIndex = 7;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.rbPerempuan.Location = new System.Drawing.Point(103, 10);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(101, 27);
            this.rbPerempuan.TabIndex = 1;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            this.rbPerempuan.CheckedChanged += new System.EventHandler(this.rbPerempuan_CheckedChanged);
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Checked = true;
            this.rbLaki.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.rbLaki.Location = new System.Drawing.Point(2, 10);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(87, 27);
            this.rbLaki.TabIndex = 0;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            this.rbLaki.CheckedChanged += new System.EventHandler(this.rbLaki_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jenis Kelamin";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbNama.Location = new System.Drawing.Point(162, 142);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(299, 26);
            this.tbNama.TabIndex = 5;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Karyawan";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbUsername.Location = new System.Drawing.Point(162, 102);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(299, 26);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(162, 25);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(299, 26);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Karyawan";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.button1.Location = new System.Drawing.Point(1113, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "KEMBALI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.button2.Location = new System.Drawing.Point(902, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "CARI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.tbCari.Location = new System.Drawing.Point(604, 31);
            this.tbCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(295, 26);
            this.tbCari.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(538, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Nama";
            // 
            // FormDataResepsionis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormDataResepsionis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDataResepsionis";
            this.Load += new System.EventHandler(this.FormDataResepsionis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbResepsionis;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTanggalLahir;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Label label14;
    }
}