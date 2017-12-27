using PizzaStore.Ingredients;

namespace PizzaStore.Factories
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Saurce CreateSaurce();
        Cheese CreateCheese();
        Veggie[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }
}
