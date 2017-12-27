using System;
using PizzaStore.Factories;

namespace PizzaStore.Pizzas
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            _dough = _ingredientFactory.CreateDough();
            _source = _ingredientFactory.CreateSaurce();
            _clam = _ingredientFactory.CreateClam();

            Console.WriteLine($"Tossing {_dough} dough");
            Console.WriteLine($"Adding {_source} source");
            Console.WriteLine($"Adding {_clam} clam");
        }
    }
}
