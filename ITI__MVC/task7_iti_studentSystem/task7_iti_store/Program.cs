

namespace task7_iti_store
{


    record Product(int Id, string Name, double Price);    // value equality 


    public  class Program
    {
        static void PrintProduct(Product p, bool showPrice = true)
        {
            if (showPrice)
                Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");
            else
                Console.WriteLine($"Product: {p.Name}");
        }

        static void Main()
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop", 15000),
                new Product(2, "Mouse", 200),
                new Product(3, "Keyboard", 500)
            };

            Queue<Product> cart = new Queue<Product>();  //  fifo

       
            cart.Enqueue(products[0]);
            cart.Enqueue(products[2]);

            double total = 0;

            Console.WriteLine("Checkout:");
            while (cart.Count > 0)
            {
                Product p = cart.Dequeue();
                PrintProduct(p);
                total += p.Price;
            }

            Console.WriteLine($"Total Price = {total}");
        }
    }
}


