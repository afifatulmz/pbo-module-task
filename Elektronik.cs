using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Elektronik : Produk
    {
        public int Garansi;

        public Elektronik(string nama, double harga, int garansi) : base(nama, harga)
        {
            this.Garansi = garansi;
        }

        public void CekGaransi()
        {
            Console.WriteLine($"Garansi produk ini adalah {Garansi} bulan");
        }

        public override void Kategori()
        {
            Console.WriteLine($"Kategori produk ini adalah elektronik");
        }
    }

}
