using DesignPatterns.Patterns.Observer;

namespace DesignPatterns.Demo
{
    public class ObserverDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            var car = new Car();

            car.UpdateStatus("Starting");

            var observer1 = new CarObserver("Observer 1");
            car.Attach(observer1);

            car.UpdateStatus("Running");

            var observer2 = new CarObserver("Observer 2");
            car.Attach(observer2);

            car.UpdateStatus("Speed increasing");

            car.Detach(observer1);
            car.UpdateStatus("Slowing");

            car.Detach(observer2);
            car.UpdateStatus("Idle");
        }
    }
}
