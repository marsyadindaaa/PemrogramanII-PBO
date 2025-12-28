using MySql.Data.MySqlClient;
using P11_714240039.constroller;
using P11_714240039.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P11_714240039
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        Mahasiswa mahasiswa = new Mahasiswa();


        public void Tampil()

        {
            string query = "SELECT npm, nama, angkatan, alamat, email, nohp FROM t_mahasiswa";
            DataMahasiswa.DataSource = koneksi.ShowData(query);
        }

        public void ResetForm()
        {
            textboxNPM.Text = "";
            textboxNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            textboxAlamat.Text = "";
            textboxEmail.Text = "";
            textboxNohp.Text = "";
            textboxCariData.Text = "";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil Method Tampil
            Tampil();
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textboxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textboxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textboxNohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }


        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (textboxNPM.Text == "" || textboxNama.Text == "" ||
                comboBoxAngkatan.SelectedIndex == -1 ||
                textboxAlamat.Text == "" ||
                textboxEmail.Text == "" ||
                textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh Kosong", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_mahasiswa m_mhs = new M_mahasiswa();

                m_mhs.Npm = textboxNPM.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mahasiswa.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNPM.Text == "" || textboxNama.Text == "" ||
                comboBoxAngkatan.SelectedIndex == -1 ||
                textboxAlamat.Text == "" ||
                textboxEmail.Text == "" ||
                textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_mahasiswa m_mhs = new M_mahasiswa();

                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mahasiswa.Update(m_mhs, textboxNPM.Text);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Cek apakah NPM kosong atau tidak
            if (textboxNPM.Text == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Membuat konfirmasi sebelum menghapus 
                DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (pesan == DialogResult.Yes)
                {
                    // Memanggil method delete dari controller mahasiswa
                    mahasiswa.Delete(textboxNPM.Text);

                    // Mereset form dan menyegarkan tampilan data
                    ResetForm();
                    Tampil();
                }
            }
        }

        private void textboxCariData_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM t_mahasiswa WHERE npm LIKE @param OR nama LIKE @param";

            DataMahasiswa.DataSource = koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@param", "%" + textboxCariData.Text + "%")
            );
        }
    }
}

