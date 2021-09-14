using System;

namespace PizzeriaWithFactoryPattern
{
    public class Pizzeria
    {
        public static void RequestPizza()
        {
            Console.WriteLine("===========Pizzeria===========");
            Console.WriteLine("Tell pizza (P)epperoni or (Cheese \n)");
            var choised = Console.ReadLine().ToUpper();
            try
            {
                Pizza pizza = PizzaSimpleFactory.CreatePizza(choised);
                pizza.Prepare();
                pizza.Bake(10);
                pizza.Pack();
                Console.WriteLine("pizza finished");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro : {ex.Message}");
            }
        }
    }
}
