using System;
using PizzaStore.Ingredients;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        protected string _name;
        protected Dough _dough;
        protected Saurce _source;
        protected Pepperoni _pepperoni;
        protected Veggie[] _veggies;
        protected Cheese _cheese;
        protected Clam _clam;

        public abstract void Prepare();

        public string GetDescription()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place Pizza in official PizzaStore box");
        }
    }
}
