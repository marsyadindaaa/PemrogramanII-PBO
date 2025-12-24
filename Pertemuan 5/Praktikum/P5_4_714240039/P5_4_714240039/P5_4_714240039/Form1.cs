using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5_4_714240039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            //  Validasi ComboBox & TextBox
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Nama belum diisi!");
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih mata kuliah!");
                return;
            }

            // Validasi RadioButton (kelas)
            RadioButton jadwal = null;
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    jadwal = rb;
                    break;
                }
            }

            if (jadwal == null)
            {
                MessageBox.Show("Silakan pilih jadwal!");
                return;
            }


            //Validasi CheckBox (jadwal)
            List<string> kelasDipilih = new List<string>();

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    kelasDipilih.Add(cb.Text);
                }
            }

            if (kelasDipilih.Count == 0)
            {
                MessageBox.Show("Silakan pilih kelas!");
                return;
            }

            //Jika semua valid → tampilkan hasil
            string output =
       $"Nama: {textBox1.Text}\n" +
       $"Jenis Kelamin: {comboBox2.Text}\n" +
       $"Tanggal Lahir: {dateTimePicker1.Value:dd MMMM yyyy}\n" +
       $"Kelas: {string.Join(", ", kelasDipilih)}\n" +
       $"Jadwal: {jadwal.Text}";

            MessageBox.Show(output, "Data Lengkap");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
