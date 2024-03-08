using DesignPatterns.Patterns.Adapter;

namespace DesignPatterns.Demo
{
    public class AdapterDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            OldCar oldCar = new OldCar("Alfa Romeo Spider");
            ISmartCar smartCar = new CarAdapter(oldCar);
            smartCar.AutoStart();
        }
    }
}
