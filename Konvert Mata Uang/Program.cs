using System;

namespace Konvert_Mata_Uang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Rate USD ke RP :");
            double HargaUSD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jumlah USD :");
            double JumlahUang = Convert.ToDouble(Console.ReadLine());

            double Hasil = HargaUSD * JumlahUang;
            Console.WriteLine("Hasil konversi : Rp. "+Hasil);
            Console.ReadLine();
        }
    }
}
