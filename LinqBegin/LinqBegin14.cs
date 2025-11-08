using System;
using System.Linq;

namespace LinqBegin
{
    public static class LinqBegin14
    {
        public static void Solve()
        {
            int A = 1;
            int B = 5;
            
            double result = Enumerable.Range(A, B - A + 1)
                                     .Select(x => x * x)
                                     .Average();
            
            Console.WriteLine($"Среднее арифметическое квадратов от {A} до {B}: {result:F2}");
        }
    }
}
