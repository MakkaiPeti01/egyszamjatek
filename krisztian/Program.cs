using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krisztian
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 1, 2, 2, 2, 2, 3, 4, 4 };
            int nyeroszam = 0;
            for (int i = 0; i < tomb.Length-1;)
            {
                if (tomb[i] == tomb[i + 1])
                {
                    i++;
                }
                else
                    if (tomb[i + 1] == tomb[i + 2])
                {
                    i++;
                }
                else break;
                nyeroszam = tomb[i + 1];
            }
            Console.WriteLine(nyeroszam);
            Console.ReadKey();
        }
    }
}
