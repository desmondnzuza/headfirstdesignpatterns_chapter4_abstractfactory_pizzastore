using PizzaStore.Ingredients;
using PizzaStore.Ingredients.Cheeses;
using PizzaStore.Ingredients.Clams;
using PizzaStore.Ingredients.Doughs;
using PizzaStore.Ingredients.Pepperonies;
using PizzaStore.Ingredients.Saurces;
using PizzaStore.Ingredients.Veggies;

namespace PizzaStore.Factories
{
    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Saurce CreateSaurce()
        {
            return new PlumTomatoSource();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[] {new BlackOlives(), new Spinach(), new EggPlant()};
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clam CreateClam()
        {
            return new FrozenClams();
        }
    }
}
