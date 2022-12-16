/*UTS-EDI PUTRA YUNI_2207111395*/
using System;

namespace NameTag
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Nama         : ");
            string nama = Console.ReadLine();
            Console.Write("NIM          : ");
            string nim = Console.ReadLine();
            Console.Write("Konsentrasi  : ");
            string konsentrasi = Console.ReadLine();
            mahasiswaBaru mhs = new mahasiswaBaru(nama,nim,konsentrasi);
            mhs.printNameTag();
        }
    }
    class mahasiswaBaru
    {
        string nama;
        string nim;
        string konsentrasi;

        public mahasiswaBaru(string Nama,string NIM,string Konsentrasi)
        {
            nama = Nama;
            nim = NIM;
            konsentrasi = Konsentrasi;
        }
        public void printNameTag()
        {
            Console.WriteLine();
            Console.WriteLine("      --MAHASISWA BARU--    ");        
            Console.WriteLine("|**************************|");
            Console.WriteLine("|Nama :{0,20}|",nama);
            Console.WriteLine("|      {0,20}|",nim);
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|            {0,14}|",konsentrasi);
            Console.WriteLine("|**************************|");
        }
    }    
}