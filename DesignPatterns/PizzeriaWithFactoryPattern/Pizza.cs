namespace PizzeriaWithFactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public abstract void Bake(int time);
        public abstract void Prepare();
        public abstract void Pack();

    }
}
