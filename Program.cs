
using System;

namespace SistemProdukToko
{
   class Program
    {
        static void Main(string[] args) 
        {
            Toko tokoAfifah = new Toko();

            Laptop laptopGaming = new Laptop("ASUS ROG Zephyrus G14", 40999000, 24 );
            Hp HPflagship = new Hp("RedMagic 11 Pro", 19999000, 12);
            Snack makaroni = new Snack("Boncabe", 10000, new DateOnly(2027, 12, 25));
            Minuman susu = new Minuman("Ultra Milk", 7000, new DateOnly(2026, 12, 25));

            tokoAfifah.TambahProduk(laptopGaming);
            tokoAfifah.TambahProduk(HPflagship);
            tokoAfifah.TambahProduk(makaroni);
            tokoAfifah.TambahProduk(susu);

            Console.WriteLine("---- Daftar Produk Di Toko Afifah ----");
            tokoAfifah.DaftarProduk();

            Console.WriteLine("\n ---- Jawaban Tugas ----");

            Console.WriteLine("Soal 1 jawabannya:");
            laptopGaming.Kategori();
            makaroni.Kategori();

            Console.WriteLine("\nSoal 2 jawabannya:");
            laptopGaming.InstallSoftware();

            Console.WriteLine("\nSoal 3 jawabannya:");
            laptopGaming.InfoProduk();
            laptopGaming.CekGaransi();

            Console.WriteLine("\nSoal 4 jawabannya:");
            susu.Dinginkan();

            Console.WriteLine("\nSoal 5 jawabannya:");
            Produk produkRandom = new Hp("Samsung A13", 2000000, 12);
            produkRandom.Kategori();

        }
    }

}
