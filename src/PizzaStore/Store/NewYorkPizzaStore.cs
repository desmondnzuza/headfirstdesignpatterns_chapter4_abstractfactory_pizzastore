using PizzaStore.Factories;
using PizzaStore.Pizzas;

namespace PizzaStore.Store
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NewYorkIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese");
            }
            else if (type.Equals("Greek"))
            {
                pizza = new GreekPizza(ingredientFactory);
                pizza.SetName("New York Style Greek");
            }
            else if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pepperoni");
            }
            else if (type.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie");
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam");
            }

            return pizza;
        }
    }
}
