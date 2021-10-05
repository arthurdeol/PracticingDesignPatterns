using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Pizzeria ========\n");
            Console.WriteLine("Tell the local (S)São Paulo  (R)Rio de Janeiro");
            var local = Console.ReadLine().ToUpper();

            Console.WriteLine("Tell the local (M)Mussarela  (C)Calabreza");
            var flavor = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethod pizzeria = PizzaSimpleFactory.CreatePizzeria(local);
                var pizza = pizzeria.MontaPizza(flavor);
                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nYour pizza is ready");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
