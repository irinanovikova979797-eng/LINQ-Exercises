using System;
using System.Linq;

namespace LinqBegin
{
    public static class LinqBegin1
    {
        public static void Solve()
        {
            int[] numbers = { -5, 3, -2, 8, -1, 4, -7, 6 };
            
            int firstPositive = numbers.First(x => x > 0);
            int lastNegative = numbers.Last(x => x < 0);
            
            Console.WriteLine($"Первый положительный: {firstPositive}");
            Console.WriteLine($"Последний отрицательный: {lastNegative}");
        }
    }
}
