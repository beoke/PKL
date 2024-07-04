using System.Diagnostics.Metrics;
using System.Reflection;

namespace Latih5_DataListObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BMW = new Mobil
            {
                TipeMobil = "BMW sedan",
                Warna = "Putih",
                VolumeMesin = 2500,
                MaxKecepatan = 180,
                BahanBakar = "Pertamax Turbo",
                TglProduksi = new DateTime(2020, 1, 2)
            };
            var Fortuner = new Mobil
            {
                TipeMobil = "SUV",
                Warna = "Abu abu",
                VolumeMesin = 2500,
                BahanBakar = "Dex",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2022, 11, 22)
            };

            var Rubicon = new Mobil
            {
                TipeMobil = "SUV",
                Warna = "Hitam",
                VolumeMesin = 2000,
                BahanBakar = "Dex",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2022, 3, 30)
            };
            var listmobil = new List<Mobil>();
            listmobil.Add(BMW);
            listmobil.Add(Fortuner);
            listmobil.Add(Rubicon);


           
            foreach (var item in listmobil)
            {
                Console.WriteLine($"Tipe Mobil: {item.TipeMobil}");
                Console.WriteLine($"Warna: {item.Warna}");
                Console.WriteLine($"Volume Mesin: {item.VolumeMesin}");
                Console.WriteLine($"Max Kecepatan: {item.MaxKecepatan}");
                Console.WriteLine($"Bahan Bakar: {item.BahanBakar}");
                Console.WriteLine($"TglProduksi: {item.TglProduksi.ToString("dd-MM-yyyy")}");
                Console.WriteLine();
            }
                
        }
    }
}
