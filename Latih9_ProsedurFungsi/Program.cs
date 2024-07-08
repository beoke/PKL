namespace Latih9_ProsedurFungsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //latihan 1
            TampilkanWaktu();

            //latihan 2
            int a = 7;
            int b = 6;
            int hasil = kali(a,b);
            Console.WriteLine("latihan 2");
            Console.WriteLine("hasil Perkalian 6 * 7 adalah " + hasil);
            Console.WriteLine();

            //latihan 3
            Console.WriteLine("latihan 3");
            Console.WriteLine("Masukkan angka");
            int c = int.Parse(Console.ReadLine());
            bool GenapAtauGanjil= ApakahGenap(c);
            Console.WriteLine("Angka tersebut "+ GenapAtauGanjil);
        }

        static void TampilkanWaktu() //latihan 1
        {
            Console.WriteLine("latihan 1");
            DateTime waktuSekarang = DateTime.Now;
            Console.WriteLine("Waktu saat ini adalah " + waktuSekarang);
            Console.WriteLine();
        }

        static int kali(int a, int b) // latihan 2
        {
            return a * b;
        }

        static bool ApakahGenap(int x)
        {
           return x % 2 == 0;  
        }
    }
}
