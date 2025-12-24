namespace P11_714240039.view
{
    partial class FormNilai
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.ComboBoxNPM = new System.Windows.Forms.ComboBox();
            this.ComboBoxKategori = new System.Windows.Forms.ComboBox();
            this.ComboBoxMatkul = new System.Windows.Forms.ComboBox();
            this.textBoxNilai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCariData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataNilai);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Data Nilai";
            // 
            // DataNilai
            // 
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(7, 19);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.Size = new System.Drawing.Size(856, 208);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNama);
            this.groupBox2.Controls.Add(this.ComboBoxNPM);
            this.groupBox2.Controls.Add(this.ComboBoxKategori);
            this.groupBox2.Controls.Add(this.ComboBoxMatkul);
            this.groupBox2.Controls.Add(this.textBoxNilai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Nilai";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(352, 106);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(218, 20);
            this.textBoxNama.TabIndex = 8;
            // 
            // ComboBoxNPM
            // 
            this.ComboBoxNPM.FormattingEnabled = true;
            this.ComboBoxNPM.Location = new System.Drawing.Point(68, 105);
            this.ComboBoxNPM.Name = "ComboBoxNPM";
            this.ComboBoxNPM.Size = new System.Drawing.Size(278, 21);
            this.ComboBoxNPM.TabIndex = 7;
            this.ComboBoxNPM.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNPM_SelectedIndexChanged);
            // 
            // ComboBoxKategori
            // 
            this.ComboBoxKategori.FormattingEnabled = true;
            this.ComboBoxKategori.Items.AddRange(new object[] {
            "ATS",
            "AAS"});
            this.ComboBoxKategori.Location = new System.Drawing.Point(68, 59);
            this.ComboBoxKategori.Name = "ComboBoxKategori";
            this.ComboBoxKategori.Size = new System.Drawing.Size(278, 21);
            this.ComboBoxKategori.TabIndex = 6;
            // 
            // ComboBoxMatkul
            // 
            this.ComboBoxMatkul.FormattingEnabled = true;
            this.ComboBoxMatkul.Items.AddRange(new object[] {
            "Pemrograman I ",
            "Pemrograman II ",
            "Pemrograman III ",
            "Pemrograman IV",
            "Literasi Data ",
            "Sistem ERP ",
            "RPL ",
            "Metodologi Penelitian ",
            "PKN ",
            "General English I"});
            this.ComboBoxMatkul.Location = new System.Drawing.Point(68, 17);
            this.ComboBoxMatkul.Name = "ComboBoxMatkul";
            this.ComboBoxMatkul.Size = new System.Drawing.Size(278, 21);
            this.ComboBoxMatkul.TabIndex = 5;
            // 
            // textBoxNilai
            // 
            this.textBoxNilai.Location = new System.Drawing.Point(68, 150);
            this.textBoxNilai.Name = "textBoxNilai";
            this.textBoxNilai.Size = new System.Drawing.Size(278, 20);
            this.textBoxNilai.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCariData);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(594, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 42);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // textBoxCariData
            // 
            this.textBoxCariData.Location = new System.Drawing.Point(63, 16);
            this.textBoxCariData.Name = "textBoxCariData";
            this.textBoxCariData.Size = new System.Drawing.Size(213, 20);
            this.textBoxCariData.TabIndex = 5;
            this.textBoxCariData.TextChanged += new System.EventHandler(this.textBoxCariData_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cari Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonHapus);
            this.groupBox4.Controls.Add(this.buttonUbah);
            this.groupBox4.Controls.Add(this.buttonSimpan);
            this.groupBox4.Controls.Add(this.buttonRefresh);
            this.groupBox4.Location = new System.Drawing.Point(594, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 138);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(9, 109);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(267, 23);
            this.buttonHapus.TabIndex = 3;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(9, 80);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(267, 23);
            this.buttonUbah.TabIndex = 2;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(9, 49);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(267, 23);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(9, 20);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(267, 23);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxNPM;
        private System.Windows.Forms.ComboBox ComboBoxKategori;
        private System.Windows.Forms.ComboBox ComboBoxMatkul;
        private System.Windows.Forms.TextBox textBoxNilai;
        private System.Windows.Forms.TextBox textBoxCariData;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}