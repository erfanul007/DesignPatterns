using DesignPatterns.Patterns.Facade;

namespace DesignPatterns.Demo
{
    public class FacadeDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            var entertainmentSystem = new EntertainmentSystem(new Television(), new DVDPlayer(), new Soundbox(), new MusicPlayer());
            Console.WriteLine("1. Watch movie");
            Console.WriteLine("2. Listen music");
            Console.Write("Chose one: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    entertainmentSystem.PlayMovie();
                    break;
                case "2":
                    entertainmentSystem.PlayMusic("Gulabi akhein by jal");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
        }
    }
}
