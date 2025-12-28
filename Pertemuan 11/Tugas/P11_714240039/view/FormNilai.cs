using MySql.Data.MySqlClient;
using P11_714240039.constroller;
using P11_714240039.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714240039.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        Nilai nilai = new Nilai();      // Controller
        M_nilai m_nilai = new M_nilai(); // Model

        string id_nilai;

        public void Tampil()
        {
            DataNilai.DataSource = koneksi.ShowData(
            "SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
            "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm"
            );

            //mengubah nama header tabel
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Mata Kuliah";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama Mahasiswa";
            DataNilai.Columns[5].HeaderText = "Nilai";

        }
        public FormNilai()
        {
            InitializeComponent();
        }

        public void GetDataMhs()
        {
            ComboBoxNPM.Items.Clear(); // agar tidak dobel 
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT npm FROM t_mahasiswa");
            while (reader.Read())
            {
                ComboBoxNPM.Items.Add(reader["npm"].ToString());
            }
            reader.Close();
            koneksi.CloseConnection();
        }

         public void GetNamaMhs()
        { 
        if (string.IsNullOrWhiteSpace(ComboBoxNPM.Text)) 
        return; 
        string sql = "SELECT nama FROM t_mahasiswa WHERE npm = @npm";
        DataTable dt = (DataTable)koneksi.ShowDataParam(
        sql,
        new MySqlParameter("@npm", ComboBoxNPM.Text)
        );
        textBoxNama.Text = dt.Rows[0]["nama"].ToString(); 
}

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            ComboBoxMatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            ComboBoxKategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            ComboBoxNPM.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxCariData.Text.Trim();

            // Jika kosong, tampilkan semua data 
            if (keyword == "")
            {
                Tampil();
                return;
            }

            string sql =
                "SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " +
                "WHERE CAST(t_nilai.npm AS CHAR) LIKE @param " +
                "OR nama LIKE @param " +
                "OR matkul LIKE @param";
            DataNilai.DataSource = koneksi.ShowDataParam(
            sql,
            new MySqlParameter("@param", "%" + keyword + "%")
            );

        }

        private void ComboBoxNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        public void ResetForm()
        {
            ComboBoxMatkul.SelectedIndex = -1;
            ComboBoxKategori.SelectedIndex = -1;
            ComboBoxNPM.SelectedIndex = -1;
            textBoxNilai.Text = "";
            textBoxNama.Text = "";
            textBoxCariData.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (ComboBoxMatkul.SelectedIndex == -1 || ComboBoxKategori.SelectedIndex ==
1 ||            ComboBoxNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_nilai m_nilai = new M_nilai();
                Nilai nilaiController = new Nilai();

                m_nilai.Matkul = ComboBoxMatkul.Text;
                m_nilai.Kategori = ComboBoxKategori.Text;
                m_nilai.Npm = ComboBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;

                nilai.Insert(m_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (ComboBoxMatkul.SelectedIndex == -1 || ComboBoxKategori.SelectedIndex ==
                1 || ComboBoxNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = ComboBoxMatkul.Text;
                m_nilai.Kategori = ComboBoxKategori.Text;
                m_nilai.Npm = ComboBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;

                nilai.Update(m_nilai, id_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?","Perhatian",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                ResetForm();
                Tampil();
            }
        }
    }
}
