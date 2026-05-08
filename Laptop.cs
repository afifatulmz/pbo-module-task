using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Laptop : Elektronik
    {
        public Laptop(string nama, double harga, int garansi) : base(nama, harga, garansi)
        {
        }

        public void InstallSoftware()
        {
            Console.WriteLine($"Install software di laptop: {Nama}");
        }

        public override void Kategori()
        {
            Console.WriteLine($"Laptop ini termasuk kategori elektronik");
        }
    }
}
