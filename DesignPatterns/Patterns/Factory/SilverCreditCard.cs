namespace DesignPatterns.Patterns.Factory
{
    public class SilverCreditCard : ICreditCard
    {
        public int CreditCardCharge()
        {
            return 100;
        }

        public int CreditCardLimit()
        {
            return 50000;
        }

        public string CreditCardName()
        {
            return "Silver";
        }
    }
}
