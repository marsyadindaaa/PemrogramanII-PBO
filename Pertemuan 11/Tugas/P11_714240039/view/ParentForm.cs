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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;   // agar tampil di dalam ParentForm
            f.Show();
        }

        private void dataNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai frmNilai = new FormNilai();
            frmNilai.MdiParent = this;
            frmNilai.Show();
        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang fb = new FormBarang();
            fb.MdiParent = this;
            fb.Show();

        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi ft = new FormTransaksi();
            ft.MdiParent = this;
            ft.Show();

        }
    }
}

