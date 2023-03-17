using Caffetteria.Data;

namespace Caffetteria.Interfaces
{
    public interface ICoffee
    {
        Name name { get; set; }
        decimal price { get; set; }
        Service service { get; set; }
        Topping topping { get; set; }
        List<Topping> toppings { get; set; }
        Data.Type type { get; set; }

        decimal CalculatePrice();
    }
}