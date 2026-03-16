using System;
using System.Collections.Generic;

namespace SkorTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> skorTablosu = new PriorityQueue<string, int>();

            skorTablosu.Enqueue("Ahmet", -85);
            skorTablosu.Enqueue("Zeynep", -95); 
            skorTablosu.Enqueue("Can", -70);
            skorTablosu.Enqueue("Deniz", -90);
            skorTablosu.Enqueue("Ece", -60);

            Console.WriteLine("--- En Yüksek 3 Oyuncu ---\n");

            
            for (int i = 1; i <= 3; i++)
            {
                if (skorTablosu.Count > 0)
                {
                    
                    string oyuncu = skorTablosu.Dequeue();
                    Console.WriteLine($"{i}. Sırada: {oyuncu}");
                }
            }

            Console.ReadKey();
        }
    }
}