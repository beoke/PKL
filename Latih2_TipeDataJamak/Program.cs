namespace Latih2_TipeDataJamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nilaimurid = new Dictionary<string, int>
            {
                { "Budi", 86 },
                { "Siti", 91 },
                { "Adit", 100 }
            };
            Console.WriteLine("Nilai Budi: " + nilaimurid ["Budi"]);
            Console.WriteLine("Nilai Siti: " + nilaimurid ["Siti"]);
            Console.WriteLine("Nilai Adit: " + nilaimurid ["Adit"]);
            nilaimurid["Mamad"] = 95;
            Console.WriteLine("Nilai Mamad: " + nilaimurid["Mamad"]);
        }
    }
}
