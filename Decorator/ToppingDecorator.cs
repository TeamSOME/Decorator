using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class ToppingDecorator : IPizza
    {
        private IPizza _pizza;
        public ToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
           return  _pizza.GetPizzaType();
        }
        public virtual double GetCost()
        {
           return  _pizza.GetCost();
        }
    }
}
