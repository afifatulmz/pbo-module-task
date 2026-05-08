using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Snack : Makanan
    {
        public Snack(string nama, double harga, DateOnly tanggalKadaluarsa) : base(nama, harga, tanggalKadaluarsa)
        {
        }

        public void Makan()
        {
            Console.WriteLine($"sedang makan snack: {Nama}");
        }

        public override void Kategori()
        {
            Console.WriteLine("Snack termasuk kategori makanan");
        }
    }
}
