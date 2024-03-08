using DesignPatterns.Demo;

namespace DesignPatterns
{
    public class DesignPatternsDemo
    {
        public void ChoseDemo()
        {
            IDesignPatternDemo demo = null;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Singleton");
                Console.WriteLine("2. Factory");
                Console.WriteLine("3. Abstract Factory");
                Console.WriteLine("4. Adapter");
                Console.WriteLine("5. Facade");
                Console.WriteLine("6. Observer");
                Console.WriteLine("7. Command");
                Console.Write("Chose one for demo: ");
                var input = Console.ReadLine();

                if(input == "1")
                {
                    demo = new SingletonDemo();
                }
                else if(input == "2")
                {
                    demo = new FactoryDemo();
                }
                else if(input == "3")
                {
                    demo = new AbstractFactoryDemo();
                }
                else if (input == "4")
                {
                    demo = new AdapterDemo();
                }
                else if (input == "5")
                {
                    demo = new FacadeDemo();
                }
                else if (input == "6")
                {
                    demo = new ObserverDemo();
                }
                else if (input == "7")
                {
                    demo = new CommandDemo();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    break;
                }
                demo.RunDemo();
            }
        }
    }
}
