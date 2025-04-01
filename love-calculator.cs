using System;

namespace LoveCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KALKULATOR CINTA by IRWAN ===");
            Console.WriteLine("=== Program ini hanya untuk hiburan semata, just for fun :)");
            Console.WriteLine("Masukkan nama Anda dan nama pasangan untuk menghitung kecocokan!");
            
            Console.Write("Nama Anda: ");
            string nama1 = Console.ReadLine();
            
            Console.Write("Nama Pasangan: ");
            string nama2 = Console.ReadLine();

            int loveScore = CalculateLove(nama1, nama2);
            
            Console.WriteLine("\nHasil Kalkulator Cinta:");
            Console.WriteLine($"{nama1} dan {nama2} memiliki kecocokan sebesar {loveScore}%");
            
            // Tampilkan pesan berdasarkan skor
            DisplayLoveMessage(loveScore);
            
            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }

        static int CalculateLove(string name1, string name2)
        {
            string combined = (name1 + name2).ToLower();
            int total = 0;
            
            foreach (char c in combined)
            {
                if (c >= 'a' && c <= 'z')
                {
                    total += c - 'a' + 1;
                }
            }
            
            // Hasilkan angka antara 50-100 untuk hasil yang lebih "menyenangkan"
            Random rnd = new Random();
            int baseScore = total % 50; // 0-49
            int finalScore = 50 + baseScore + rnd.Next(0, 10);
            
            // Pastikan tidak melebihi 100%
            return Math.Min(finalScore, 100);
        }

        static void DisplayLoveMessage(int score)
        {
            if (score < 40)
            {
                Console.WriteLine("Mungkin perlu lebih banyak waktu untuk mengenal satu sama lain...");
            }
            else if (score < 60)
            {
                Console.WriteLine("Ada potensi di sini! Teruslah membangun hubungan.");
            }
            else if (score < 80)
            {
                Console.WriteLine("Pasangan yang serasi! Kalian memiliki chemistry yang baik.");
            }
            else
            {
                Console.WriteLine("Pasangan yang sempurna! Cinta kalian sangat kuat!");
            }
        }
    }
}