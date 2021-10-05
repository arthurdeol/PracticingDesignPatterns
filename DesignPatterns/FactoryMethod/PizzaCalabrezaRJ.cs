namespace FactoryMethod
{
    public class PizzaCalabrezaRJ : Pizza
    {
        public PizzaCalabrezaRJ()
        {
            Name = "Pizza calabreza Carioca";
            pasta = "Massa fina crocante carioca";
            sauce = "Molho de tomate italiano carioca";
            ingredients.Add("Chesse");
            ingredients.Add("Azeitonas verdes");
        }
    }
}
