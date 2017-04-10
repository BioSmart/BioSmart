using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMOCModel;

namespace SIMOCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MostPopularNumber(new uint[] { 22, 101, 102, 101, 102, 102 }));
            Console.ReadKey();
        }

        public static uint MostPopularNumber(uint[] array)
        {
            var i = from numbers in array
                    group numbers by numbers into grouped
                    select new KeyValuePair<uint, int>(grouped.Key, grouped.Count());

            var popular = i.Where(x => x.Value == i.Max(y => y.Value));
            return popular.Min(x => x.Key);
        }
    }
}
