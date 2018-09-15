using DAL.Repositories;
using ORM;

namespace PL.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new TeaAndCoffeeDbContext())
            {
                var repository = new CoffeeRepository(context);
                foreach (var coffee in repository.GetAll())
                {
                    System.Console.WriteLine($"{coffee.Name} {coffee.CoffeeSortId}");
                }
            }
        }
    }
}
