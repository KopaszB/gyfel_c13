using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C.13.feladat: Írassa ki 99-től csökkenő sorrendben az összes pozitív, 3-al osztható pozitív egész számot!

namespace gyfel_c13
{
    class Program
    {
        static void Main()
        {
            int i = 100;
            int j = 0;
            while (i-- > 1)
            {
                if (i % 3 != 0)
                {
                    continue;
                }
                Console.Write(i + " ");
                j++;
                if (j % 6 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();  
        }
    }
}
