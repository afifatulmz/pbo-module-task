using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Makanan : Produk
    {
        public DateOnly tanggalKadaluarsa;

        public Makanan(string nama, double harga, DateOnly tanggalKadaluarsa) : base(nama, harga)
        {
            this.tanggalKadaluarsa = tanggalKadaluarsa;
        }

        public void CekKadaluarsa()
        {
            Console.WriteLine($"Best Before: {tanggalKadaluarsa}");
        }

        public override void Kategori()
        {
            Console.WriteLine($"Kategori produk ini adalah makanan");
        }
    }

}