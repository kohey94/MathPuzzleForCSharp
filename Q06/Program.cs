using System;

namespace Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q06 （改造版）コラッソの予想");

            var cnt = 0;

            for (int i = 2; i <= 10000; i += 2)
            {
                var num = i;

                num = num * 3 + 1;

                while (true)
                {
                    num = (num % 2 == 0) ? num / 2 : num * 3 + 1;

                    if (num == i || num == 1)
                    {
                        break;
                    }
                }

                if (num == i)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
