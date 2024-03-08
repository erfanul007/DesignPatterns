namespace DesignPatterns.Patterns.Factory
{
    public interface ICreditCard
    {
        string CreditCardName();
        int CreditCardLimit();
        int CreditCardCharge();
    }
}
