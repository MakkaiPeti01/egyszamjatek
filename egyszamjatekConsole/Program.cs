using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace egyszamjatekConsole
{
    class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static int fordulo;
        static void beolvasas()
        {
            StreamReader olvas = new StreamReader("egyszamjatek1.txt");
            while (!olvas.EndOfStream)
            {
                versenyzok.Add(new Versenyzo(olvas.ReadLine()));
            }
            olvas.Close();
        }
        static void harmadikFeladat()
        {
            Console.WriteLine("A játékban {0} versenyző vett részt", versenyzok.Count);
        }
        static void negyedikFeladat()
        {
            Console.Write("4.feladat, kérem a forduló sorszámát: ");
            fordulo = int.Parse(Console.ReadLine());                  
        }
        static void otodikFeladat()
        {
            double atlag = 0;
            double osszeg = 0;
            foreach (var v in versenyzok)
            {
                osszeg += v.Eredmeny(fordulo);
            }
            atlag= osszeg/versenyzok.Count;
            Console.WriteLine(Math.Round(atlag,2));         
        }
        static void Main(string[] args)
        {
            beolvasas();
            harmadikFeladat();
            negyedikFeladat();
            otodikFeladat();
           /* Console.Write("Kérek egy fordulot: ");
            int fordulo = int.Parse(Console.ReadLine());
            foreach (var v in versenyzok)
            {
                Console.WriteLine(v.Eredmeny(fordulo));
            }*/
            Console.ReadKey();
        }
    }
}
