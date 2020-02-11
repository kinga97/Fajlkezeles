using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[30];
            List<int> paratlanok = new List<int>();
            List<int> ketjegyu = new List<int>();
            int ossz = 0;
            int negativ = 0;
            using (StreamReader sr = new StreamReader("szamok.txt", Encoding.UTF8))
            {
               
                for (int i = 0; i < 30; i++)
                {
                    tomb[i] = Int32.Parse(sr.ReadLine());
                    ossz = ossz + tomb[i];
                    if (tomb[i] <0)
                    {
                        negativ++;
                    }
                    if (tomb[i] % 2 != 0)
                    {
                        paratlanok.Add(tomb[i]);
                    }
                    if (Math.Abs(tomb[i]) >= 10 && Math.Abs(tomb[i]) <= 99)
                    {
                        ketjegyu.Add(tomb[i]);
                    }
                    
                }
            }
            Console.WriteLine($" 1.Feladat: Az összeg: {ossz}");
            Console.WriteLine($" 1.Feladat: Negatív számok összege: {negativ}");
            Console.Write($" 3.Feladat: Paratlan szamok:");
            foreach (var item in paratlanok)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"\n 4.Feladat: kétjegyű számok:");
            foreach (var item in ketjegyu)
            {
                Console.Write($"{item} ");
            }

            Console.Write($"\n5.Feladat: Kérek egy számot 50 és 100 között: ");
            int eddig = Int32.Parse(Console.ReadLine());
            int szamlal = 0;
            string kiir = "";

            for (int i = 0; i < tomb.Length; i++)
            {
                szamlal += tomb[i];
                if (szamlal < eddig)
                {
                    kiir += $"({tomb[i]}) +";
                }
                else
                {
                    kiir += $"({tomb[i]}) >= {eddig}";
                    break;
                    //continue;
                }
                
            }
            Console.WriteLine(kiir);

            Console.ReadKey(true);
        }
    }
}
