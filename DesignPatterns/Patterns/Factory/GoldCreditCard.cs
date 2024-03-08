namespace DesignPatterns.Patterns.Factory
{
    public class GoldCreditCard : ICreditCard
    {
        public int CreditCardCharge()
        {
            return 250;
        }

        public int CreditCardLimit()
        {
            return 150000;
        }

        public string CreditCardName()
        {
            return "Gold";
        }
    }
}
