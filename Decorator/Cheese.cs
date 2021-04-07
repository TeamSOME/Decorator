using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Cheese: ToppingDecorator
    {
        public Cheese(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\n With extra cheese";
            return type;
        }
        public override double GetCost()
        {
            double price = base.GetCost();
            price += 7.0;
            return price;
        }
    }
}
