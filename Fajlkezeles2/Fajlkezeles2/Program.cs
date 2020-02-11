using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlkezeles2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tomb = new int[53];

            using (StreamReader sr = new StreamReader("szamokfejlecdb.txt", Encoding.UTF8))
            {

                int darab = 0;
                int vanenulla = 0;
                int ujertek = 0;
                
                for (int i = 0; i < 53; i++)
                {
                    tomb[i] = Int32.Parse(sr.ReadLine());

                    if (tomb[i] >= 15)
                    {
                        darab++;
                    }

                    if (tomb[i] == 0)
                    {
                        vanenulla++;  
                    }

                    if (tomb[i] > ujertek)
                    {
                        ujertek = tomb[i];
                    }

                    
                }
                Array.Sort(tomb);
                Console.WriteLine($"1. feladat: {darab - 1}");
                Console.WriteLine($"2. feladat: {ujertek}");
                Console.WriteLine($"3. feladat: Ennyi nulla van a számok között: {vanenulla}");
                Console.WriteLine("4. feladat: ");
                foreach (int i in tomb)
                {
                    Console.Write(i + " ");
                }
                
                

            }


            Console.ReadKey(true);
        }
    }
}
