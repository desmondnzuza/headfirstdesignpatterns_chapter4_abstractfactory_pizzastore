using PizzaStore.Factories;
using PizzaStore.Pizzas;

namespace PizzaStore.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza                               = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chicago Style Cheese");
            }
            else if (type.Equals("Greek"))
            {
                pizza = new GreekPizza(ingredientFactory);
                pizza.SetName("Chicago Style Greek");
            }
            else if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chicago Style Cheese Pepperoni");
            }
            else if (type.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chicago Style Veggie");
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chicago Style Clam");
            }

            return pizza;
        }
    }
}
