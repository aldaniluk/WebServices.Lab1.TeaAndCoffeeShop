using PL.Console.CoffeeServiceReference;
using SC = System.Console;

namespace PL.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new CoffeeServiceClient())
            {
                foreach (CoffeeBll coffee in client.GetAll())
                {
                    SC.WriteLine($"{coffee.Name} {coffee.CoffeeSort} {coffee.MadeFromCountry.Name}");
                }
            }
        }
    }
}
