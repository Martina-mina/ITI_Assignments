namespace project2_day1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] names = { "martina", "mina", "issa", "MARY" };

            var q1 = names.Where(n => n.Length == 3);
            Console.WriteLine("Query1:");
            foreach (var n in q1)
                Console.WriteLine(n);

       
            var q2 = names.Where(n => n.ToLower().Contains("a"))
                          .OrderBy(n => n.Length);
            Console.WriteLine("Query2:");
            foreach (var n in q2)
                Console.WriteLine(n);

          
            var q3 = names.Take(2);
            Console.WriteLine("Query3:");
            foreach (var n in q3)
                Console.WriteLine(n);

        }
    }
}
