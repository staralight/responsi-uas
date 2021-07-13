using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        nomorMenu = 1;
                        break;

                    case 2:
                        HapusPenjualan();
                        nomorMenu = 2;
                        break;

                    case 3:
                        TampilPenjualan();
                        nomorMenu = 3;
                        break;

                    case 4: // keluar dari program
                        nomorMenu = 4;
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.WriteLine("Tampil Menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan \n2. Hapus Penjualan \n3. Tampilkan Penjualan \n4. Keluar");
            Console.Write("Nomor Menu [1...4]: ");
            int Nomor = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Penjualan.nota = 007;
            Penjualan.tanggal = 07 - 07 - 2020;
            Penjualan.customer = Anis;
            Penjualan.jenis = T;
            Penjualan.totalnota = 500000;


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
