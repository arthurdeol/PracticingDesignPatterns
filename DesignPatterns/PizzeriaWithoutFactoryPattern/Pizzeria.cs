using System;

namespace PizzeriaWithoutFactoryPattern
{
    public class Pizzeria
    {
        public static void RequestPizza()
        {
            PepperoniPizza pizza1;
            CheesePizza pizza2;
            Console.WriteLine("===========Pizzeria===========");
            Console.WriteLine("Tell pizza (P)epperoni or (Cheese \n)");
            var choised = Console.ReadLine().ToUpper();

            if (choised.Equals("C"))
            {
                pizza2 = new CheesePizza();
                pizza2.Prepare();
                pizza2.Bake(10);
                pizza2.Pack();
                Console.WriteLine("pizza finished");
            }
            else if (choised.Equals("P"))
            {
                pizza1 = new PepperoniPizza();
                pizza1.Prepare();
                pizza1.Bake(10);
                pizza1.Pack();
                Console.WriteLine("pizza finished");
            }
            else
            {
                Console.WriteLine("This pizza doesn't exist.");
            }
        }
    }
}
