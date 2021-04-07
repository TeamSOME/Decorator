using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CalzonePizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a calzone pizza";
        }
        public double GetCost()
        {
            return 50.0;
        }
    }
}
