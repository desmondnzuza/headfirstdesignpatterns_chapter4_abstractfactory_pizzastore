using PizzaStore.Ingredients;
using PizzaStore.Ingredients.Cheeses;
using PizzaStore.Ingredients.Clams;
using PizzaStore.Ingredients.Doughs;
using PizzaStore.Ingredients.Pepperonies;
using PizzaStore.Ingredients.Saurces;
using PizzaStore.Ingredients.Veggies;

namespace PizzaStore.Factories
{
    public class TraditionalIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Saurce CreateSaurce()
        {
            return new MarinaSaurce();
        }

        public Cheese CreateCheese()
        {
            return new RegianoCheese();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[] {new Garlic(), new Onion(), new Mushroom(), new RedPeppers()};
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clam CreateClam()
        {
            return new FreshClams();
        }
    }
}
