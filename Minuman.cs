using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Minuman : Makanan
    {

        public Minuman(string nama, double harga, DateOnly tanggalKadaluarsa) : base(nama, harga, tanggalKadaluarsa)
        {
            this.tanggalKadaluarsa = tanggalKadaluarsa;
        }

        public void Dinginkan()
        {
            Console.WriteLine($"Mendinginkan minuman");
        }

        public override void Kategori()
        {
            Console.WriteLine($"Minuman termasuk kategori makanan");
        }
    }

}