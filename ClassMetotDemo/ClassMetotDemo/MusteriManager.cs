using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void Add(Musteriler m)
        {
            Console.WriteLine(m.FirstName + "  adlı musteri Eklendi!");
        }
        public static void Delete(Musteriler m)
        {
            Console.WriteLine(m.FirstName + "adlı musteri Silindi!");
        }
    }
}
