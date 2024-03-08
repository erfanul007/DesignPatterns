using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    public class Car
    {
        private List<IObserver> _observers;
        private string _status;

        public Car()
        {
            _status = string.Empty;
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void UpdateStatus(string newStatus)
        {
            _status = newStatus;
            NotifyObserver();
        }

        private void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_status);
            }
        }
    }
}
