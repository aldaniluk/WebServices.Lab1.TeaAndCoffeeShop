using ORM;

namespace PL.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TeaAndCoffeeDbContext())
            {
                foreach (var coffee in context.Set<Country>())
                {
                    System.Console.WriteLine($"{coffee.Name}");
                }
            }
        }
    }
}
