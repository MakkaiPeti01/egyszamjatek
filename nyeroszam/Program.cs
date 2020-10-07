using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyeroszam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Listában eltárolni a számokat(ismétlődés)
                * listát sorba rendezzük sort()
                * egyesével megszámolni hányszor fordul elő a sorozatban
             *eltároljuk szintén egy listában(előfordulás)
            * (megszámlálás tétele)
             *megnézzük az előfordulást:
             *-ha nincs benne 1, nincs nyertes
             *-ha van benne akkor a legkisebb ertékű a nyertes*/
            int[] tomb = new int[] { 1, 1, 2, 2, 2, 2, 3, 3, 4, 4 };
            #region regimegoldas
            /*List<int> lista = new List<int>();
               List<int> db = new List<int>();
               foreach (var t in tomb)
               {
                   if (!lista.Contains(t))
                   {
                       lista.Add(t);
                   }
               }
               lista.Sort();
               foreach (var sz in lista)
               {
                   int mennyi = 0;
                   foreach (var t in tomb)
                   {
                       if (sz == t)
                       {
                           mennyi++;
                       }
                   }
                   db.Add(mennyi);
               }
               /* for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{lista[i]} : {db[i]}");
                }*/
            /*int i = 0;
            while (i < lista.Count && db[i] != 1)
            {
                i++;
            }
            if (i < lista.Count)
            {
                Console.WriteLine("A nyerő szám {0}", lista[i]);
            }
            else
            {
                Console.WriteLine("Nincs nyerő szám");
            }*/
            #endregion
            Dictionary<int, int> szamok = new Dictionary<int, int>();
            foreach (var i in tomb)
            {
                if (szamok.ContainsKey(i))
                {
                    szamok[i] = szamok[i] + 1;
                }
                else
                {
                    szamok.Add(i, 1);
                }
            }
            foreach (var i in szamok)
            {
                Console.WriteLine(i.Key+ "-->" +i.Value);
            }
            if (szamok.ContainsValue(1))
            {
                Console.WriteLine("Van nyerő szám");
            }
            else
            {
                Console.WriteLine("Nincs nyerő szám");
            }
            Console.ReadKey();
        }
    }
}
