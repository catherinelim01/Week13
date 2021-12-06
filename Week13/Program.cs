using System;

namespace Week13
{
    class Program
    {
        public static void Catherine()
        {
            Console.WriteLine("Praktikum Week 13\nCatherine Lim_0706022110002\n");
        }
        static void Main(string[] args)
        {
            Catherine();
            int banyakDataInput, banyakDataInputTambahan;
            String no = "NO", nim = "NIM", nama = "NAMA", jenisKelamin = "JENIS KELAMIN", tahunMasuk = "TAHUN MASUK", programStudi = "PROGRAM STUDI", kelas = "KELAS", titikDua = ":", printHasil = "y", tambahData = "y";
            
                Console.Write("Berapa Data = ");
                banyakDataInput = Convert.ToInt16(Console.ReadLine());

                string[,] guildData = new string[banyakDataInput, 6];
                string[] guildNIM = new string[banyakDataInput];

                for (int i = 0; i < banyakDataInput; i++)
                {
                    Console.WriteLine("\ndata ke-" + (i + 1));
                    Console.Write(String.Format("{0,0}{1,17} ", nim, titikDua));
                    guildData[i, 0] = Console.ReadLine();

                    for (int j = 0; j < banyakDataInput; j++)
                    {
                        while (guildData[i, 0] == guildNIM[j] && i != j)
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKAN NIM LAIN !!!");
                            Console.Write(String.Format("{0,0}{1,17} ", nim, titikDua));
                            guildData[i, 0] = Console.ReadLine();
                            j = 0;
                        }
                    }
                    guildNIM[i] = guildData[i, 0];

                    Console.Write(String.Format("{0,0}{1,16} ", nama, titikDua));
                    guildData[i, 1] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,7} ", jenisKelamin, titikDua));
                    guildData[i, 2] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,9} ", tahunMasuk, titikDua));
                    guildData[i, 3] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,7} ", programStudi, titikDua));
                    guildData[i, 4] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,15} ", kelas, titikDua));
                    guildData[i, 5] = Console.ReadLine();

                }
                Console.WriteLine("\nPRINT HASIL? (y/n)");
                printHasil = Console.ReadLine();
                if (printHasil == "y")
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-25}{3,-15}{4,-15}{5,-15}{6,-5} ", no, nim, nama, jenisKelamin, tahunMasuk, programStudi, kelas));
                    for (int k = 0; k < banyakDataInput; k++)
                    {
                        Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-25}{3,-15}{4,-15}{5,-15}{6,-5} ", (k + 1), guildData[k, 0], guildData[k, 1], guildData[k, 2], guildData[k, 3], guildData[k, 4], guildData[k, 5]));
                    }
                }
                Console.WriteLine("\nTambah Data? (y/n)");
                tambahData = Console.ReadLine();
            if (tambahData == "y" && tambahData != "n")
            {
                Console.Write("Berapa Data = ");
                banyakDataInputTambahan = Convert.ToInt16(Console.ReadLine());

                string [,] guildDataSimpan = new string[(banyakDataInput + banyakDataInputTambahan), 6];
                for (int i = 0; i < banyakDataInput; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        guildDataSimpan[i,j] = guildData[i, j];
                    }    
                }
                guildData = new string [(banyakDataInput + banyakDataInputTambahan), 6];
                guildNIM = new string [(banyakDataInput + banyakDataInputTambahan)];

                for (int i = banyakDataInput; i < banyakDataInput + banyakDataInputTambahan; i++)
                {
                    Console.WriteLine("\ndata ke-" + (i + 1));
                    Console.Write(String.Format("{0,0}{1,17} ", nim, titikDua));
                    guildData[i, 0] = Console.ReadLine();

                    for (int j = 0; j < i; j++)
                    {
                        while (guildData[i, 0] == guildNIM[j] && i != j)
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKAN NIM LAIN !!!");
                            Console.Write(String.Format("{0,0}{1,17} ", nim, titikDua));
                            guildData[i, 0] = Console.ReadLine();
                            j = 0;
                        }
                    }
                    
                    guildNIM[i] = guildData[i, 0];

                    Console.Write(String.Format("{0,0}{1,16} ", nama, titikDua));
                    guildData[i, 1] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,7} ", jenisKelamin, titikDua));
                    guildData[i, 2] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,9} ", tahunMasuk, titikDua));
                    guildData[i, 3] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,7} ", programStudi, titikDua));
                    guildData[i, 4] = Console.ReadLine();

                    Console.Write(String.Format("{0,0}{1,15} ", kelas, titikDua));
                    guildData[i, 5] = Console.ReadLine();
                  
                }
                Console.WriteLine("\nPRINT HASIL? (y/n)");
                printHasil = Console.ReadLine();
                if (printHasil == "y")
                {
                    Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-25}{3,-15}{4,-15}{5,-15}{6,-5} ", no, nim, nama, jenisKelamin, tahunMasuk, programStudi, kelas));
                    for (int k = 0; k < banyakDataInput; k++)
                    {
                        Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-25}{3,-15}{4,-15}{5,-15}{6,-5} ", (k + 1), guildDataSimpan[k, 0], guildDataSimpan[k, 1], guildDataSimpan[k, 2], guildDataSimpan[k, 3], guildDataSimpan[k, 4], guildDataSimpan[k, 5]));
                    }
                    for (int k = banyakDataInputTambahan; k < banyakDataInput + banyakDataInputTambahan; k++)
                    {
                        Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-25}{3,-15}{4,-15}{5,-15}{6,-5} ", (k + 1), guildData[k, 0], guildData[k, 1], guildData[k, 2], guildData[k, 3], guildData[k, 4], guildData[k, 5]));
                    }
                }
                Console.WriteLine("\nTambah Data? (y/n)");
                tambahData = Console.ReadLine();
            }
        }
    }
}
