namespace EventsAndDelegates.Interfaces
{
    public interface ISubscriber
    {
        void Subscribe(IPublisher publisher);
        void Unsubscribe(IPublisher publisher);
        void Notify(string message);
    }
}