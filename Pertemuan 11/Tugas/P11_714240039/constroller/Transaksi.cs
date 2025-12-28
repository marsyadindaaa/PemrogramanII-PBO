using MySql.Data.MySqlClient;
using System.Data;
using P11_714240039.model;
using System;

namespace P11_714240039.constroller
{
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        public DataTable Tampil()
        {
            DataTable dt = new DataTable();

            koneksi.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total " +
                "FROM t_transaksi t JOIN t_barang b ON t.id_barang = b.id_barang",
                koneksi.GetConnection()
            );

            da.Fill(dt);
            koneksi.CloseConnection();

            return dt;
        }

        public void Insert(M_transaksi tr)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@idb, @qty, @total)",
                koneksi.GetConnection()
            );

            cmd.Parameters.AddWithValue("@idb", tr.IdBarang);
            cmd.Parameters.AddWithValue("@qty", tr.Qty);
            cmd.Parameters.AddWithValue("@total", tr.Total);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }

        public void Update(M_transaksi tr)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_transaksi SET qty=@qty, total=@total WHERE id_barang=@idb",
                koneksi.GetConnection()
            );

            cmd.Parameters.AddWithValue("@qty", tr.Qty);
            cmd.Parameters.AddWithValue("@total", tr.Total);
            cmd.Parameters.AddWithValue("@idb", tr.IdBarang);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }

        public void Delete(int idBarang)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_transaksi WHERE id_barang=@idb",
                koneksi.GetConnection()
            );

            cmd.Parameters.AddWithValue("@idb", idBarang);
            cmd.ExecuteNonQuery();

            koneksi.CloseConnection();
        }

        internal bool CekIdBarang(int idBarang)
        {
            throw new NotImplementedException();
        }
    }
}
