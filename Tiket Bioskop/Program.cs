﻿/*UTS-EDI PUTRA YUNI-2207111395*/
using System;

namespace TiketBioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Mulai :
            string Harga;
            Console.WriteLine("Nama: ");
            string Nama = Console.ReadLine();
            Console.WriteLine("Tahun Kelahiran: ");
            int TahunKelahiran = Convert.ToInt32(Console.ReadLine());
            
            int Usia = 2022 - TahunKelahiran;

            if(Usia < 10 || Usia > 60)
                {
                    Harga = "Rp     10000.00";
                }
                else
                {
                    Harga = "Rp     25000.00";
                }
                Console.WriteLine("|****************************|");
                Console.WriteLine("|       -- STUDIO 1 --       |");
                Console.WriteLine(String.Format("|{0,-10}{1,18}|", "Nama  : ", Nama));
                Console.WriteLine(String.Format("|{0,-1}{1,20}|", "Harga : ", Harga));
                Console.WriteLine("|----------------------------|");
            
        }  
    }
}