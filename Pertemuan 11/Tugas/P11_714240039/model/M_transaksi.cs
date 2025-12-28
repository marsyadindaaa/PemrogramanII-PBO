using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_714240039.model
{
    internal class M_transaksi
    {
            // Primary key transaksi
            public int IdTransaksi { get; set; }

            // Foreign key ke tabel barang
            public int IdBarang { get; set; }

            // Quantity barang
            public int Qty { get; set; }

            // Total harga
            public int Total { get; set; }
        
    }

}

