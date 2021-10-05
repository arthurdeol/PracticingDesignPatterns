namespace FactoryMethod
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Name = "Pizza mussarela Carioca";
            pasta = "Massa fina crocante carioca";
            sauce = "Molho de tomate italiano carioca";
            ingredients.Add("Chesse");
            ingredients.Add("Azeitonas verdes");
        }
    }

}
