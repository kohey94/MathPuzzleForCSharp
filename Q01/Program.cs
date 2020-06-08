using System;
using System.Linq;

namespace Q01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q01 10進数で回文");

            var num = 11;

            while (num < 1000)
            {
                var dNum = num.ToString();
                var bNum = Convert.ToString(num, 2);
                var hNum = Convert.ToString(num, 8);
                if (dNum == string.Concat(dNum.Reverse()) &&
                    bNum == string.Concat(bNum.Reverse()) &&
                    hNum == string.Concat(hNum.Reverse()))
                {
                    Console.WriteLine($"10進数、2進数、8進数のいずれで表現しても回文数となる数のうち10進数の10以上で最小の値は {num}");
                    Console.WriteLine($"10進数:{num}");
                    Console.WriteLine($" 2進数:{bNum}");
                    Console.WriteLine($" 8進数:{hNum}");
                    break;
                }

                num++;
            }
        }
    }
}
