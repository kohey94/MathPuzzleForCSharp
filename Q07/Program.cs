using System;
using System.Linq;

namespace Q07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q07 日付の2進数変換");

            var startDate = 19641010;
            var endDate = 20200724;
            var cnt = 0;
            var dateStr = startDate.ToString().Insert(6, "/").Insert(4, "/");           
            var date = Convert.ToDateTime(dateStr);

            while (date.ToString("yyyyMMdd") != endDate.ToString())
            {
                var bDate = Convert.ToString(Convert.ToInt32(date.ToString("yyyyMMdd")), 2);
                
                var bDateRev = string.Concat(bDate.Reverse());
                
                var dateRev = Convert.ToInt32(bDateRev, 2);
                
                if (Convert.ToInt32(date.ToString("yyyyMMdd")) == dateRev )
                {
                    Console.WriteLine(dateRev);
                    cnt++;
                }

                date = date.AddDays(1);
            }
            Console.WriteLine($"{cnt}個");
        }
    }
}
