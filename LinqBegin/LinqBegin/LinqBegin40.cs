using System;
using System.Linq;

namespace LinqBegin
{
    public static class LinqBegin40
    {
        public static void Solve()
        {
            int K = 4;
            string[] A = { "apple", "cat", "dog", "banana", "hi", "test" };
            
            var result = A.Where(s => s.Length >= K)
                         .SelectMany(s => s)
                         .Reverse();
            
            Console.WriteLine($"K = {K}");
            Console.WriteLine($"Результат: {string.Join(", ", result)}");
        }
    }
}
