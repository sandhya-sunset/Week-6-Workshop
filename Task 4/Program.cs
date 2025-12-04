namespace Task4;

class Program
{

    static void Main(string[] args)
    {
        // Question 1
        int[] numbers = { 1, 2, 3, 4, 5 };
        var squaredNumbers = numbers.Select(n => n * n);
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }



        // Question 2
        Book[] books =
        [
            new("Learn Javascript", 600),
            new("Fundamentals Of Programming", 2100),
            new("Core Java", 800),
            new("Software Engineering", 1100),
            new("Data Structure and Algorithm", 1900),
            new("Fundamentals of Computing", 400),
            new("Introduction to AI/ML", 3000),
            new("How not to Code", 900)
        ];

        var premiumBooks = books.Where(book => book.Price > 1000).ToList();

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("Premium books:");
        Console.WriteLine("------------------------------------");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine(book.Name);
        }
        Console.WriteLine("------------------------------------");



        // Question 3
        Student[] students =
        [
            new Student("Alex", new DateOnly(2004, 12, 2), "Male"),
            new Student("Sakshyam", new DateOnly(2004, 3, 5), "Male"),
            new Student("Dinesh", new DateOnly(2006, 7, 23), "Male"),
            new Student("Debina", new DateOnly(2005, 11, 9), "Female"),
            new Student("Ram", new DateOnly(2004, 2, 17), "Male"),
            new Student("Sita", new DateOnly(2006, 9, 30), "Female"),
            new Student("Krishna", new DateOnly(2005, 4, 14), "Male"),
            new Student("Gita", new DateOnly(2004, 12, 1), "Female"),
            new Student("Irfan", new DateOnly(2006, 6, 8), "Male"),
            new Student("Babita", new DateOnly(2005, 8, 21), "Female")
        ];

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("Students Sorted By Name Alphabetically:");
        Console.WriteLine("------------------------------------");
        students.OrderBy(student => student.Name).ToList().ForEach(student => Console.WriteLine(student.Name));
        Console.WriteLine("------------------------------------");

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("Students Sorted By Name Reverse Alphabetically:");
        Console.WriteLine("------------------------------------");
        students.OrderByDescending(student => student.Name).ToList().ForEach(student => Console.WriteLine(student.Name));
        Console.WriteLine("------------------------------------");
    }
}