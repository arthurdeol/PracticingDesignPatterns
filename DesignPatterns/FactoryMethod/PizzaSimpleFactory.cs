using System;

namespace FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CreatePizzeria(string local)
        {
            PizzaFactoryMethod pizzeria;

            switch(local)
            {
                case "S":
                    pizzeria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzeria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException($"The pizzeria {local} don't exist.");
            }

            return pizzeria;
        }
    }
}
