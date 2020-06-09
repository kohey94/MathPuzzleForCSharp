using System;
using System.Runtime.InteropServices;

namespace Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q04 棒の切り分け");
            
            EchoResult(20, 3);
            EchoResult(100, 5);
        }

        static void EchoResult(int lodLength, int saws)
        {
            Console.WriteLine($"{lodLength}cmの棒を{saws}人で切り分けると{CountCuttingLod(lodLength, saws)}回で切り分けられる。");
        }

        static int CountCuttingLod(int lodLength, int saws)
        {
            var x = 1;
            var cnt = 0;
            while (x < lodLength)
            {
                x += x < saws ? x : saws;
                cnt++;
            }
            return cnt;
        }
    }
}
