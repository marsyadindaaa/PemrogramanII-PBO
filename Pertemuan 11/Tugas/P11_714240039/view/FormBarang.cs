using System;
using System.Data;
using System.Windows.Forms;
using P11_714240039.constroller;
using P11_714240039.model;

namespace P11_714240039.view
{
    public partial class FormBarang : Form
    {
        Barang brg = new Barang();
        M_barang mb = new M_barang();

        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            TampilData();
            Bersih();
        }

        void TampilData()
        {
            dgvBarang.DataSource = brg.TampilBarang();
        }

        void Bersih()
        {
            txtIdBarang.Clear();
            txtNamaBarang.Clear();
            txtHarga.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (txtIdBarang.Text == "" || txtNamaBarang.Text == "" || txtHarga.Text == "")
            {
                MessageBox.Show("Lengkapi data barang!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mb.IdBarang = int.Parse(txtIdBarang.Text);
            mb.NamaBarang = txtNamaBarang.Text;
            mb.Harga = int.Parse(txtHarga.Text);

            brg.Insert(mb);
            MessageBox.Show("Data barang berhasil disimpan!", "Success");

            TampilData();
            Bersih();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (txtIdBarang.Text == "")
            {
                MessageBox.Show("Pilih data barang dulu!", "Warning");
                return;
            }

            mb.IdBarang = int.Parse(txtIdBarang.Text);
            mb.NamaBarang = txtNamaBarang.Text;
            mb.Harga = int.Parse(txtHarga.Text);

            brg.Update(mb);
            MessageBox.Show("Data barang berhasil diubah!", "Success");

            TampilData();
            Bersih();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (txtIdBarang.Text == "")
            {
                MessageBox.Show("Pilih data barang dahulu!", "Warning");
                return;
            }

            int id = int.Parse(txtIdBarang.Text);
            brg.Delete(id);
            MessageBox.Show("Data barang berhasil dihapus!");

            TampilData();
            Bersih();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            Bersih();
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvBarang.Rows[e.RowIndex];
                    txtIdBarang.Text = row.Cells["id_barang"].Value.ToString();
                    txtNamaBarang.Text = row.Cells["nama_barang"].Value.ToString();
                    txtHarga.Text = row.Cells["harga"].Value.ToString();
                }
            }
            catch { }
        }
    }
}
