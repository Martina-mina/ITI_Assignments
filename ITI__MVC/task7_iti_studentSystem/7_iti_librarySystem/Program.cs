namespace _7_iti_librarySystem
{

    static class Extensions
    {
        public static string Separated (this HashSet<string> books)   // مفيهاش تكرار 
        {
            return string.Join(", ", books);
        }
    }


    public  class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> books = new HashSet<string>
            {
                "C# Basics","OOP Principles","Data Structures", "C# Basics" 
            };

            Console.WriteLine("Books in library:");
            Console.WriteLine(books.Separated());
        }
    }
}