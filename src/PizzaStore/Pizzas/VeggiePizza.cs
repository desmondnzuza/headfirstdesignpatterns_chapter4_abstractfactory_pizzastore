using System;
using PizzaStore.Factories;

namespace PizzaStore.Pizzas
{
    class VeggiePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            _dough = _ingredientFactory.CreateDough();
            _source = _ingredientFactory.CreateSaurce();
            _veggies = _ingredientFactory.CreateVeggies();

            Console.WriteLine($"Tossing {_dough} dough");
            Console.WriteLine($"Adding {_source} source");

            if (_veggies.Length > 0)
            {
                Console.WriteLine("Adding veggies:");
                foreach (var veg in _veggies)
                {
                    Console.WriteLine($"\t :{veg}");
                }
            }
        }
    }
}
