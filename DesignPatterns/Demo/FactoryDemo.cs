using DesignPatterns.Patterns.Factory;

namespace DesignPatterns.Demo
{
    public class FactoryDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            Console.WriteLine("1. Silver");
            Console.WriteLine("2. Gold");
            Console.WriteLine("3. Titanium");
            Console.Write("Enter credit card type: ");
            var input = Console.ReadLine();

            ICreditCard creditCard = CreditCardFactory.RegisterCreditCard(input);
            if (creditCard == null)
            {
                Console.WriteLine("Invalid Credit Card Type");
            }
            else
            {
                Console.WriteLine("Credit Card Name: " + creditCard.CreditCardName());
                Console.WriteLine("Credit Card Limit: " + creditCard.CreditCardLimit());
                Console.WriteLine("Credit Card Charge: " + creditCard.CreditCardCharge());
            }
        }
    }
}
