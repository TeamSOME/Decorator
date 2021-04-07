using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Ananas : ToppingDecorator
    {
        public Ananas(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\n With extra ananas";
            return type;
        }
        public override double GetCost()
        {
            double price = base.GetCost();
            price += 20.0;
            return price;
        }
    }
}
