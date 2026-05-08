using System;
using System.Collections.Generic;
using System.Text;

namespace SistemProdukToko
{
    public class Toko
    {
        List<Produk> daftarProduk = new List<Produk>();

        public void TambahProduk(Produk produk)
        {
            daftarProduk.Add(produk);
        }

        public void DaftarProduk() 
        {
            foreach (var p in daftarProduk) 
            {
                p.InfoProduk();
                p.Kategori();
                Console.WriteLine("--------------------");
            }
        }

    }
}
