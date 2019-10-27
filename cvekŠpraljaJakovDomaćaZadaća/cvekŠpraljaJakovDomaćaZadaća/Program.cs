
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            float unosOcjene;
            float kolikoOcjena;
            float zbroj;
            float prosjekOcjena;


            Console.WriteLine("Koliko ocjena zelite upisati: ");

            kolikoOcjena = Console.Read();

            for (float i = 0; i < kolikoOcjena; i++) ;
            {
                Console.WriteLine("Unesi ocjenu (1-5): ");

                unosOcjene = Console.Read();

                Console.WriteLine(unosOcjene);

                for (unosOcjene >= 2; unosOcjene < 6;) ;
                {
                    zbroj += unosOcjene;
                    prosjekOcjena = zbroj / kolikoOcjena;
                }
                if (unosOcjene = 1)
                {
                    prosjekOcjena = 1;
                }
            }
            Console.WriteLine("Prosjek ocjena je: " + prosjekOcjena);


            Console.ReadKey();
        }
    }
}