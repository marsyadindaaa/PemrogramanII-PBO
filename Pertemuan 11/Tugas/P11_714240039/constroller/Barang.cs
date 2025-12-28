using MySql.Data.MySqlClient;
using System.Data;
using P11_714240039.model;

namespace P11_714240039.constroller
{
    internal class Barang
    {
        Koneksi koneksi = new Koneksi();

        public DataTable TampilBarang()
        {
            DataTable dt = new DataTable();
            koneksi.OpenConnection();

            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT * FROM t_barang",
                koneksi.GetConnection()
            );

            da.Fill(dt);
            koneksi.CloseConnection();
            return dt;
        }

        public void Insert(M_barang b)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_barang (nama_barang, harga) VALUES (@nama, @harga)",
                koneksi.GetConnection()
            );

            cmd.Parameters.AddWithValue("@nama", b.NamaBarang);
            cmd.Parameters.AddWithValue("@harga", b.Harga);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }

        public void Update(M_barang b)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_barang SET nama_barang=@nama, harga=@harga WHERE id_barang=@id",
                koneksi.GetConnection()
            );

            cmd.Parameters.AddWithValue("@id", b.IdBarang);
            cmd.Parameters.AddWithValue("@nama", b.NamaBarang);
            cmd.Parameters.AddWithValue("@harga", b.Harga);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }

        public void Delete(int id)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_barang WHERE id_barang=@id",
                koneksi.GetConnection()
            );

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            koneksi.CloseConnection();
        }
    }
}
