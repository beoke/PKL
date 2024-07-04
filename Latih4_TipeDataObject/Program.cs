namespace Latih4_TipeDataObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BMW = new Mobil
            {
                TipeMObil = "BMW sedan",
                Warna = "Putih",
                VolumeMesin = 2500,
                MaxKecepatan = 180,
                BahanBakar = "Pertamax Turbo",
                TglProduksi = new DateTime(2020, 1, 2)
            };
            Console.WriteLine($"Tipe Mobil: {BMW.TipeMObil}");
            Console.WriteLine($"Warna: {BMW.Warna}");
            Console.WriteLine($"Volume Mesin: {BMW.VolumeMesin}");
            Console.WriteLine($"Max Kecepatan: {BMW.MaxKecepatan}");
            Console.WriteLine($"Bahan Bakar: {BMW.BahanBakar}");
            Console.WriteLine($"TglProduksi: {BMW.TglProduksi.ToString("dd-MM-yyyy")}");

        }
    }
}
