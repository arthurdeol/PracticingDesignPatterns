using System;

namespace PizzeriaWithFactoryPattern
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni";
        }
        public override void Bake(int time)
        {
            Console.WriteLine($"{Name} pizza baking for {time} minutes.");
        }

        public override void Pack()
        {
            Console.WriteLine($"Packing {Name} pizza.");
        }

        public override void Prepare()
        {
            Console.WriteLine($"\nPreparing {Name} pizza");
        }
    }
}
