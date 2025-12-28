using MySql.Data.MySqlClient;
using P11_714240039.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714240039.constroller
{
    internal class Mahasiswa
    {
        //Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_mahasiswa mahasiswa)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                var cmd = new MySqlCommand(
                    "INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp) " +
                    "VALUES (@npm, @nama, @angkatan, @alamat, @email, @nohp)",
                    koneksi.GetConnection()
                );

                cmd.Parameters.AddWithValue("@npm", mahasiswa.Npm);
                cmd.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                cmd.Parameters.AddWithValue("@angkatan", mahasiswa.Angkatan);
                cmd.Parameters.AddWithValue("@alamat", mahasiswa.Alamat);
                cmd.Parameters.AddWithValue("@email", mahasiswa.Email);
                cmd.Parameters.AddWithValue("@nohp", mahasiswa.Nohp);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Insert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }


        //method update
        public bool Update(M_mahasiswa mahasiswa, string npm_mhs)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                var cmd = new MySqlCommand(
                    "UPDATE t_mahasiswa SET nama=@nama, angkatan=@angkatan, alamat=@alamat, email=@email, nohp=@nohp " +
                    "WHERE npm=@npm",
                    koneksi.GetConnection()
                );

                cmd.Parameters.AddWithValue("@npm", npm_mhs);
                cmd.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                cmd.Parameters.AddWithValue("@angkatan", mahasiswa.Angkatan);
                cmd.Parameters.AddWithValue("@alamat", mahasiswa.Alamat);
                cmd.Parameters.AddWithValue("@email", mahasiswa.Email);
                cmd.Parameters.AddWithValue("@nohp", mahasiswa.Nohp);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data Berhasil Diubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
        // Method Delete
        public bool Delete(string npm_mhs)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                // Tambahkan koneksi.GetConnection() agar perintah tahu database mana yang digunakan
                var cmd = new MySqlCommand(
                    "DELETE FROM t_mahasiswa WHERE npm=@npm",
                    koneksi.GetConnection()
                );

                cmd.Parameters.AddWithValue("@npm", npm_mhs);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data Berhasil Dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
    }

}
