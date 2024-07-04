namespace Latih3_CollectionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> NamaSiswa = new List<string>
        {
            "Bram", "Yoga", "Ani", "Budi", "Adit"
        };

            Console.WriteLine("Daftar nama siswa:");
            for (int i = 0; i < NamaSiswa.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {NamaSiswa[i]}");
            }
        }
    }
}
