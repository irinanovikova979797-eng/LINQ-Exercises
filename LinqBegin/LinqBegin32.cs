using System;
using System.Linq;

namespace LinqBegin
{
    public static class LinqBegin32
    {
        public static void Solve()
        {
            string[] A = { "apple", "banana", "cherry", "date", "elderberry" };
            
            var result = A.Select(s => s[0])
                         .Reverse();
            
            Console.WriteLine($"Результат: {string.Join(", ", result)}");
        }
    }
}
