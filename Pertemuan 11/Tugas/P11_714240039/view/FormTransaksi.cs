using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P11_714240039.constroller;
using P11_714240039.model;
using System.Globalization;



namespace P11_714240039.view
{
    public partial class FormTransaksi : Form
    {
        Transaksi tr = new Transaksi();
        Barang brg = new Barang();
        M_transaksi mt = new M_transaksi();

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            TampilData();
            LoadBarang();
            Bersih();
        }

        void TampilData()
        {
            dgvTransaksi.DataSource = tr.Tampil();
        }

        void LoadBarang()
        {
            cmbIdBarang.DataSource = brg.TampilBarang();
            cmbIdBarang.DisplayMember = "id_barang";
            cmbIdBarang.ValueMember = "id_barang";
            cmbIdBarang.SelectedIndex = -1;
        }

        void Bersih()
        {
            cmbIdBarang.SelectedIndex = -1;
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtQty.Clear();
            txtTotal.Clear();
        }

        private void cmbIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdBarang.SelectedIndex != -1)
            {
                DataRowView drv = (DataRowView)cmbIdBarang.SelectedItem;
                txtNamaBarang.Text = drv["nama_barang"].ToString();
                int harga = int.Parse(drv["harga"].ToString());
                txtHarga.Text = FormatRupiah(harga);

            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != "" && txtHarga.Text != "")
            {
                int harga = int.Parse(txtHarga.Text.Replace("Rp", "").Replace(".", "").Trim());

                int qty = int.Parse(txtQty.Text);
                int total = harga * qty;
                txtTotal.Text = FormatRupiah(total);

            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            int idBarang = int.Parse(cmbIdBarang.Text);

            if (tr.CekIdBarang(idBarang))
            {
                MessageBox.Show("Id Barang sudah ada, silakan lakukan Update");
                return;
            }

            string totalBersih = txtTotal.Text
                .Replace("Rp", "")
                .Replace(".", "")
                .Trim();

            


            mt.IdBarang = idBarang;
            mt.Qty = int.Parse(txtQty.Text);
            mt.Total = int.Parse(totalBersih);

            tr.Insert(mt);
            MessageBox.Show("Data berhasil disimpan");

            TampilData();
            Bersih();
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                cmbIdBarang.Text = row.Cells["id_barang"].Value.ToString();
                txtNamaBarang.Text = row.Cells["nama_barang"].Value.ToString();
                int harga = int.Parse(row.Cells["harga"].Value.ToString());
                txtHarga.Text = FormatRupiah(harga);
                txtQty.Text = row.Cells["qty"].Value.ToString();
                int total = int.Parse(row.Cells["total"].Value.ToString());
                txtTotal.Text = FormatRupiah(total);

            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (cmbIdBarang.Text == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            string totalBersih = txtTotal.Text
                .Replace("Rp", "")
                .Replace(".", "")
                .Trim();

            mt.IdBarang = int.Parse(cmbIdBarang.Text);
            mt.Qty = int.Parse(txtQty.Text);
            mt.Total = int.Parse(totalBersih);

            tr.Update(mt);
            MessageBox.Show("Data berhasil diubah");

            TampilData();
            Bersih();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            int idBarang = int.Parse(cmbIdBarang.Text);

            tr.Delete(idBarang);
            MessageBox.Show("Data berhasil dihapus");

            TampilData();
            Bersih();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            Bersih();
        }

        string FormatRupiah(int angka)
        {
            return "Rp " + angka.ToString("N0", new CultureInfo("id-ID"));

        }

    }
}

