using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class PlainPizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a plain pizza";
        }
        public double GetCost()
        {
            return 45.5;
        }
    }
}
