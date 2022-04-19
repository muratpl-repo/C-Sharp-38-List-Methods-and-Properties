using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85DersCollections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(5);
            sayilar.Add(8);
            sayilar.Add(-1);
            sayilar.Add(3);
            sayilar.Add(3);
            sayilar.Add(3);
            sayilar.Add(15);

            //sayilar.Sort();           //Listedekleri siralar...
            //sayilar[2] = 123;         //2. elemani 123 yapar...
            //sayilar.Clear()           //Listeyi temizler...
            //sayilar.Insert(3, 125);   //3. indexe 125 sayisini ekler...
            //sayilar.Contains(X);      //Dizide X elemani varsa True dondurur...

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }   
    }
}
