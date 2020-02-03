using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //erre mindig szükség van a stream read és write megjelenítéséhez

namespace ElsoFajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> szovegLista = new List<string>();

            using (StreamReader sr = new StreamReader("Proba.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string beiras = sr.ReadLine();
                    szovegLista.Add(beiras);
                }
            }

            for (int i = 0; i < szovegLista.Count; i++)
            {
                Console.WriteLine(szovegLista[i]);
            }

            using (StreamWriter sw = new StreamWriter("Proba.txt", true, Encoding.UTF8))
            {
                string beir = "Ez itt a harmadik sor.";
                sw.WriteLine(beir);
            }


            Console.ReadKey(true);
        }
    }
}
