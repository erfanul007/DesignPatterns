using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    public class CarObserver : IObserver
    {
        private readonly string _name;

        public CarObserver(string name)
        {
            _name = name;
        }

        public void Update(string status)
        {
            Console.WriteLine($"{_name}: Updated status -> {status}");
        }
    }
}
