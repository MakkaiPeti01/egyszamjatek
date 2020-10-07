using System.Collections.Generic;
using System;

namespace egyszamjatekConsole
{
    class Versenyzo
    {
        public string Nev { get;}
        private List<int> tippek;
        public Versenyzo(string adat)
        {
            tippek = new List<int>();
            string[] adatok = adat.Split(' ');
            Nev = adatok[0];
            for (int i = 1; i < adatok.Length; i++)
            {
                tippek.Add(int.Parse(adatok[i]));
            }
            
        }
        public void tippekKi()
        {
            foreach (var i in tippek)
            {
                Console.Write(i+",");
            }
        }
        public int Eredmeny(int fordulo)
        {
            fordulo--;
            return tippek[fordulo];
        }
    }
}