using System;

namespace PizzeriaWithoutFactoryPattern
{
    public class PepperoniPizza
    {
        public string Name { get; set; }
        public PepperoniPizza()
        {
            Name = "Pepperoni";
        }

        public void Prepare()
        {
            Console.WriteLine($"\nPreparing {Name} pizza");
        }

        public void Bake(int time)
        {
            Console.WriteLine($"{Name} pizza baking for {time} minutes.");
        }

        public void Pack()
        {
            Console.WriteLine($"Packing {Name} pizza.");
        }
    }
}
