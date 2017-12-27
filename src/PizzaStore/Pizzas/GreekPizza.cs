using System;
using PizzaStore.Factories;

namespace PizzaStore.Pizzas
{
    public class GreekPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public GreekPizza(IPizzaIngredientFactory ingredientFactory)
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
                Console.WriteLine("Adding greek veggies:");
                foreach (var veg in _veggies)
                {
                    Console.WriteLine($"\t :{veg}");
                }
            }
        }
    }
}
