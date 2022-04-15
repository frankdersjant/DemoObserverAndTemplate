using ConsoleAppObserver.Interfaces;
using System;

namespace ConsoleAppObserver
{
    public class Observer : IObserver
    {
        public string Name { get; private set; }
        public Observer(string name, ISubject subject)
        {
            Name = name;
            subject.RegisterObserver(this);
        }

        public void Update(int price)
        {
            Console.WriteLine("Price is now " + price);
        }
    }
}
