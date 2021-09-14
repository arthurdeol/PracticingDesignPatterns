using System;

namespace PizzeriaWithFactoryPattern
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CreatePizza(string tipo)
        {
            Pizza pizza = tipo switch
            {
                "P" => new PepperoniPizza(),
                "C" => new CheesePizza(),
                _ => throw new ApplicationException($"This pizza doesn't exist."),
            };
            return pizza;
        }
    }
}
