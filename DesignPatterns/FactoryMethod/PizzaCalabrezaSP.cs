namespace FactoryMethod
{
    public class PizzaCalabrezaSP : Pizza
    {
        public PizzaCalabrezaSP()
        {
            Name = "Pizza mussarela Paulista";
            pasta = "Massa fina crocante paulista";
            sauce = "Molho de tomate italiano paulista";
            ingredients.Add("Chesse");
            ingredients.Add("Azeitonas verdes");
        }
    }
}
