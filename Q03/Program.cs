using System;
using System.Globalization;
using System.Linq;

namespace Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q03 カードを裏返せ");
            var cards = new Boolean[100]; // false:裏 true:表

            for(int i = 1; i < 100; i++)
            {
                for (int j = i; j < 100; j += (1 + i))
                {
                    cards[j] = !cards[j];
                }
            }

            for (int k = 0; k < cards.Length; k++)
            {
                if (!cards[k])
                    Console.WriteLine(k+1);
            }

        }
    }
}
