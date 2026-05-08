using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SistemProdukToko
{
    public class Produk
    {
        public string Nama;
        public double Harga;

        public Produk(string nama, double harga)
        {
            this.Nama = nama;
            this.Harga = harga;
        }

        public void InfoProduk()
        {
            Console.WriteLine($"Nama: {Nama}, Harga: Rp {Harga:N0}");
        }

        public virtual void Kategori()
        {
            Console.WriteLine($"Produk ini termasuk kategori");
        }
    }
}
