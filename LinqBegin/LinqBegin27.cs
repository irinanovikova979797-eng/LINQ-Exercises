using System;
using System.Linq;

namespace LinqBegin
{
    public static class LinqBegin27
    {
        public static void Solve()
        {
            int D = 5;
            int[] A = { 2, 8, 3, 10, 7, 4, 9, 6, 11, 1 };
            
            var result = A.SkipWhile(x => x <= D)
                         .Where(x => x > 0 && x % 2 != 0)
                         .Reverse();
            
            Console.WriteLine($"D = {D}");
            Console.WriteLine($"Результат: {string.Join(", ", result)}");
        }
    }
}
