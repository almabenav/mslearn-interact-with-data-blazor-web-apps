// using System.Threading.Tasks;

// namespace BlazingPizza.Data
// {
// public class PizzaService
//     {
//         public Task<Pizza[]> GetPizzasAsync()
//         {
//             var pizzas = new Pizza[]
//             {
//                 new Pizza { Name = "Margherita", Description = "Classic pizza with tomatoes and mozzarella", Vegetarian = true, Vegan = false, Price = 8.99m },
//                 new Pizza { Name = "Pepperoni", Description = "Pepperoni, mozzarella, and tomato sauce", Vegetarian = false, Vegan = false, Price = 9.99m },
//                 new Pizza { Name = "Hawaiian", Description = "Pineapple, ham, and cheese", Vegetarian = false, Vegan = false, Price = 10.99m }
//             };

//             return Task.FromResult(pizzas);
//         }
//     }
// }