using PizzaStore.Factories;
using PizzaStore.Pizzas;

namespace PizzaStore.Store
{
    public class TraditionalStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new TraditionalIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Traditional Style Cheese");
            }
            else if (type.Equals("Greek"))
            {
                pizza = new GreekPizza(ingredientFactory);
                pizza.SetName("Traditional Style Greek");
            }
            else if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Traditional Style Cheese Pepperoni");
            }
            else if (type.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Traditional Style Veggie");
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Traditional Style Clam");
            }

            return pizza;
        }
    }
}
