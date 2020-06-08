using System;
using System.Data;
using System.Linq;

namespace Q02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q02 数列の四則演算");

            var array = new string[] { "*", "/", "+", "-", "" };

            DataTable dc = new DataTable();
            for (int num = 1000; num < 10000; num++)
            {
                var str = num.ToString();
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        for (int k = 0; k < array.Length; k++)
                        {
                            var exp = str[0] + array[i] +
                                      str[1] + array[j] +
                                      str[2] + array[k] +
                                      str[3];
                            if (exp.Length > 4)
                            {
                                var data = dc.Compute(exp, "").ToString();
                                if (data == string.Concat(str.Reverse()))
                                {
                                    Console.WriteLine(str);
                                    Console.WriteLine($"{exp} = {data}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
