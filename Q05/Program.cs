using System;

namespace Q05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q05 いまだに現金払い？");

            var cnt = 0;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    for (int k = 0; k <= 15; k++)
                    {
                        for (int l = 0; l <= 15; l++)
                        {
                            if ((i + j + k + l) <= 15)
                            {
                                if ((i * 500 + j * 100 + k * 50 + l * 10) == 1000)
                                {
                                    cnt++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{cnt}通り");
        }
    }
}
