using ConsoleAppObserver.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleAppObserver
{
    public class Subject : ISubject
    {
        private List<IObserver> observers;
        public string ProductName { get; private set; }
        private int ProductPrice { get; set; }
        public Subject(string productName, int productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            observers = new List<IObserver>();
        }

        public int getCurrentprice()
        {
            return ProductPrice;
        }
        public void SetPrice(int p)
        {
            ProductPrice = p;
            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).Name);
            observers.Add(observer);
        }
        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
        public void NotifyObservers()
        {
            Console.WriteLine("Price is now: " + ProductPrice);

            foreach (IObserver observer in observers)
            {
                observer.Update(ProductPrice);
            }
        }
    }
}
