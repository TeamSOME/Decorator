using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza PlainPizza = new PlainPizza();
            IPizza Ananas = new Ananas(PlainPizza);

            Console.WriteLine(Ananas.GetPizzaType() + "\n\r Total cost: " + Ananas.GetCost()+" DKK");

            IPizza CalzonePizza = new CalzonePizza();
            IPizza sananas = new Ananas(CalzonePizza);
            IPizza smeat = new Meat(sananas);
            IPizza schees = new Cheese(smeat);
            Console.WriteLine(schees.GetPizzaType()+"\n\r Total cost: " + schees.GetCost()+" DKK");

        }
    }
}
