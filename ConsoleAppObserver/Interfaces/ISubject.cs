namespace ConsoleAppObserver.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
