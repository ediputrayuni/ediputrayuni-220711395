﻿/*UTS -EDI PUTRA YUNI_2207111395*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesalahan = 0; 
            String jawaban = ""; 
            bool salah = false, menang = false, kalah = false, benar = false; 
            Console.Clear(); 
            string[] soal = new string[10]; 
            soal[0] = "pulpen";
            soal[1] = "buku";
            soal[2] = "pensil";
            soal[3] = "tifex";
            soal[4] = "penghapus";
            soal[5] = "cater";
            soal[6] = "pengaris";
            soal[7] = "seragam";
            soal[8] = "tas";
            soal[9] = "sepatu";
            Random randGen = new Random(); 
            var random = randGen.Next(0, 9);
            string soalGame = soal[random];  
            char[] guess = new char[soalGame.Length]; 
 
            for (int p = 0; p < soalGame.Length; p++) { 
                guess[p] = '_'; 
            }
 
            while (menang == false && kalah == false) 
            {
                Console.Write("Huruf tebakan : ");
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < soalGame.Length; j++) 
                {
                    if (playerGuess == soalGame[j]) { 
                        benar = true; 
                        guess[j] = playerGuess; 
                    } else if (j == soalGame.Length - 1 && benar == false){ 
                        salah = true; 
                    }
                }
                Console.Clear();
                jawaban = new String(guess); 
                if (salah == true) { 
                    Console.WriteLine("Tebakan anda salah!"); 
                    kesalahan++;
                    salah = false; 
                }
                benar = false; 
                Console.WriteLine(guess); 
                Console.WriteLine();
                switch (kesalahan)
                {
                    case 1: 
                        Console.WriteLine(" |");
                        break;
                    case 2: 
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 3: 
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 4:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 5:
                        Console.WriteLine("___________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 6:
                        Console.WriteLine("___________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 7:
                        Console.WriteLine("___________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 8:
                        Console.WriteLine("___________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        break;
                    case 9:
                        Console.WriteLine("___________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine(" |");
                        break;
                    case 10:
                        Console.WriteLine("___________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine(" |");
                        break;

                    default:
                        break;
                }

                if (jawaban == soalGame) { 
                    Console.WriteLine("Selamat, anda menang!"); 
                    menang = true; 
                } else if (kesalahan == 10 && jawaban != soalGame) { 
                    Console.WriteLine("Anda kurang beruntung!"); 
                    kalah = true; 
                }
            }
        }
    }
}