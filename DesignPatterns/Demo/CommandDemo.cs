using DesignPatterns.Patterns.Command;

namespace DesignPatterns.Demo
{
    public class CommandDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            var light = new Light();
            var turnOff = new TurnOffCommand(light);
            var turnOn = new TurnOnCommand(light);
            var remote = new RemoteControl();

            remote.SetCommand(turnOn);
            remote.PressButton();

            remote.SetCommand(turnOff);
            remote.PressButton();
        }
    }
}
