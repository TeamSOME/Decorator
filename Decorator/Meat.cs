using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Meat : ToppingDecorator
    {
        public Meat (IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\n With extra meat";
            return type;
        }
        public override double GetCost()
        {
            double price = base.GetCost();
            price += 5.0;
            return price;
        }
    }
}
