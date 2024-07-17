namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        var pizzas = new Pizza[]
        {
            new Pizza {PizzaId = 1, Name = "Margerita", Description = "Pizza", Price = 100, Vegan = false, Vegetarian = false},
            new Pizza {PizzaId = 2, Name = "Margerita", Description = "Pizza", Price = 100, Vegan = false, Vegetarian = false},
            new Pizza {PizzaId = 3, Name = "Margerita", Description = "Pizza", Price = 100, Vegan = false, Vegetarian = false},
            new Pizza {PizzaId = 4, Name = "Margerita", Description = "Pizza", Price = 100, Vegan = false, Vegetarian = false},
            new Pizza {PizzaId = 5, Name = "Margerita", Description = "Pizza", Price = 100, Vegan = false, Vegetarian = false},
            new Pizza {PizzaId = 6, Name = "Margerita", Description = "Pizza", Price = 100, Vegan = false, Vegetarian = false},
        };

        return pizzas;
    }
}
