namespace iti_entityFramework_task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            var q1 = numbers.Distinct().OrderBy(x => x);
            Console.WriteLine("Query1:");
            foreach (var n in q1)
                Console.WriteLine(n);

            Console.WriteLine("Query2:");
            foreach (var n in q1)
                Console.WriteLine($"{n} => {n * n}");
        }
    }
}
