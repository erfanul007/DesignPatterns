using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns.Demo
{
    public class SingletonDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            var instance1 = Singleton.Instance;
            Console.Write("Set message for 1st instance: ");
            var input = Console.ReadLine();
            instance1.Message = input;

            var instance2 = Singleton.Instance;
            Console.WriteLine("Printing from 2nd instance: " + instance2.Message);

            var res = ReferenceEquals(instance1, instance2);

            if (res)
            {
                Console.WriteLine("Both instance are same.");
            }
        }
    }
}
