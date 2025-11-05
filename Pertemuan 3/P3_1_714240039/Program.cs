using System;

namespace P3_1_714240039
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Keliling Persegi Panjang");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1/2/3): ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        ProsesLuas();
                        break;
                    case "2":
                        ProsesKeliling();
                        break;
                    case "3":
                        Console.WriteLine("Terima kasih. Program selesai.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Tekan ENTER untuk kembali ke menu.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ProsesLuas()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Menghitung Luas Persegi Panjang ---");
                double panjang = BacaDouble("Masukkan panjang: ");
                double lebar = BacaDouble("Masukkan lebar: ");

                double luas = panjang * lebar;
                Console.WriteLine($"\nLuas = {luas}");

                Console.Write("\nUlangi perhitungan? (Y = Ya / T = Tidak) : ");
                string jawaban = Console.ReadLine().Trim().ToUpper();

                if (jawaban == "Y")
                {
                    // kembali ke menu utama sesuai permintaan dokumen
                    Console.WriteLine("Kembali ke menu utama. Tekan ENTER...");
                    Console.ReadLine();
                    break;
                }
                else if (jawaban == "T")
                {
                    // jika T maka tetap berada di proses? Dokumen menunjukkan contoh berbeda;
                    // Menginterpretasikan T sebagai "tidak ulangi" -> kembali ke menu.
                    Console.WriteLine("Tidak mengulang. Kembali ke menu utama. Tekan ENTER...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Input tidak dikenali. Kembali ke menu utama. Tekan ENTER...");
                    Console.ReadLine();
                    break;
                }
            }
        }

        static void ProsesKeliling()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Menghitung Keliling Persegi Panjang ---");
                double panjang = BacaDouble("Masukkan panjang: ");
                double lebar = BacaDouble("Masukkan lebar: ");

                double keliling = 2 * (panjang + lebar);
                Console.WriteLine($"\nKeliling = {keliling}");

                Console.Write("\nUlangi perhitungan? (Y = Ya / T = Tidak) : ");
                string jawaban = Console.ReadLine().Trim().ToUpper();

                if (jawaban == "Y")
                {
                    Console.WriteLine("Kembali ke menu utama. Tekan ENTER...");
                    Console.ReadLine();
                    break;
                }
                else if (jawaban == "T")
                {
                    Console.WriteLine("Tidak mengulang. Kembali ke menu utama. Tekan ENTER...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Input tidak dikenali. Kembali ke menu utama. Tekan ENTER...");
                    Console.ReadLine();
                    break;
                }
            }
        }

        static double BacaDouble(string prompt)
        {
            double hasil;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim();
                if (double.TryParse(input, out hasil))
                {
                    return hasil;
                }
                Console.WriteLine("Input tidak valid. Masukkan angka (boleh desimal).");
            }
        }
    }
}
