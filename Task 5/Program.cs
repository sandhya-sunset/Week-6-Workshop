using System;
using System.Linq;
using Task5;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // QUESTION 1 — Aggregation Operators
            // -------------------------------------------------------------
            CashierSales[] salesList =
            [
                new("suman", 22000),
                new("Sita", 25000),
                new("Hari", 28000),
                new("Gita", 2000),
                new("Ishwor", 21000)
            ];

            int totalCashiers = salesList.Count();
            double totalSales = salesList.Sum(s => s.Sales);
            double highestSale = salesList.Max(s => s.Sales);
            double lowestSale = salesList.Min(s => s.Sales);
            double avgSale = salesList.Average(s => s.Sales);

            Console.WriteLine("\n===============================");
            Console.WriteLine("AGGREGATION RESULTS");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: Rs. {totalSales}");
            Console.WriteLine($"Highest Sale: Rs. {highestSale}");
            Console.WriteLine($"Lowest Sale: Rs. {lowestSale}");
            Console.WriteLine($"Average Sale: Rs. {avgSale}");
            Console.WriteLine("===============================\n");



            // -------------------------------------------------------------
            // QUESTION 2 — Quantifier Operators (Any / All)
            // -------------------------------------------------------------
            Applicant[] applicants =
            [
                new("Sandhya", 20),
                new("Riya", 17),
                new("Sakya", 22),
                new("Kabita", 19),
                new("Hari", 16)
            ];

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine("======================================");
            Console.WriteLine("QUANTIFIER OPERATOR RESULTS");
            Console.WriteLine("======================================");
            Console.WriteLine($"Any applicant under 18: {anyUnder18}");
            Console.WriteLine($"All applicants above 16: {allAbove16}");
            Console.WriteLine("======================================\n");



            // -------------------------------------------------------------
            // QUESTION 3 — Element Operators
            // -------------------------------------------------------------
            Music[] songs =
            [
                new("Intro Track", 120),
                new("Love Beats", 250),
                new("Chill Vibes", 320),
                new("Epic Finale", 500)
            ];

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.Duration > 240); // > 4 min = 240 sec
            var firstAbove10Min = songs.FirstOrDefault(s => s.Duration > 600); // > 10 min = 600 sec

            Console.WriteLine("======================================");
            Console.WriteLine("ELEMENT OPERATOR RESULTS");
            Console.WriteLine("======================================");
            Console.WriteLine($"First Song: {firstSong.Title}");
            Console.WriteLine($"Last Song: {lastSong.Title}");
            Console.WriteLine($"First Song > 4 Min: {firstAbove4Min.Title}");
            Console.WriteLine($"First Song > 10 Min: {(firstAbove10Min?.Title ?? "No song found")}");
            Console.WriteLine("======================================");
        }
    }
}