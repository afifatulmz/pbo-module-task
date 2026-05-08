using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Hp: Elektronik
    {
        public Hp(string nama, double harga, int garansi) : base(nama, harga, garansi)
        {
        }

        public void Telepon()
        {
            Console.WriteLine($"Sedang menelepon di hp: {Nama}");
        }

        public override void Kategori()
        {
            Console.WriteLine($"Hp ini termasuk kategori elektronik");
        }
    }
}
