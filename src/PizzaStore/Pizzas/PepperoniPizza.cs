using System;
using PizzaStore.Factories;

namespace PizzaStore.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            _dough = _ingredientFactory.CreateDough();
            _source = _ingredientFactory.CreateSaurce();
            _pepperoni = _ingredientFactory.CreatePepperoni();

            Console.WriteLine($"Tossing {_dough} dough");
            Console.WriteLine($"Adding {_source} source");
            Console.WriteLine($"Adding {_pepperoni} pepperoni");
        }
    }
}
