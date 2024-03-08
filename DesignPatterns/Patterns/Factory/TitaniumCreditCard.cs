namespace DesignPatterns.Patterns.Factory
{
    public class TitaniumCreditCard : ICreditCard
    {
        public int CreditCardCharge()
        {
            return 500;
        }

        public int CreditCardLimit()
        {
            return 5000000;
        }

        public string CreditCardName()
        {
            return "Titanium";
        }
    }
}
