using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqObj
{
    public class Abiturient
    {
        public int Year { get; set; }
        public int SchoolNumber { get; set; }
        public string LastName { get; set; }
    }
    
    public static class LinqObj16
    {
        public static void Solve()
        {
            List<Abiturient> abiturients = new List<Abiturient>
            {
                new Abiturient { Year = 2020, SchoolNumber = 15, LastName = "Иванов" },
                new Abiturient { Year = 2021, SchoolNumber = 20, LastName = "Петров" },
                new Abiturient { Year = 2020, SchoolNumber = 15, LastName = "Сидоров" },
                new Abiturient { Year = 2022, SchoolNumber = 10, LastName = "Козлов" },
                new Abiturient { Year = 2021, SchoolNumber = 25, LastName = "Николаев" }
            };
            
            var result = abiturients
                .GroupBy(a => a.Year)
                .Select(g => new { Count = g.Count(), Year = g.Key })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.Year);
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Count} {item.Year}");
            }
        }
    }
}
