namespace DesignPatterns.Patterns.Factory
{
    public class CreditCardFactory
    {
        public static ICreditCard RegisterCreditCard(string type)
        {
            ICreditCard creditCard = null;
            if (type == "1")
            {
                creditCard = new SilverCreditCard();
            }
            else if (type == "2")
            {
                creditCard = new GoldCreditCard();
            }
            else if (type == "3")
            {
                creditCard = new TitaniumCreditCard();
            }
            return creditCard;
        }
    }
}
