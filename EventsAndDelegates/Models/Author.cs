using EventsAndDelegates.Interfaces;

namespace EventsAndDelegates.Models
{
    public record Author : DomainEntity, IPublisher
    {
        // private List<ISubscriber> _subscribers;
        public event EventHandler<MessageEventargs>? OnPublish;

        public string Name { get; init; }
        public string Description { get; init; }

        private Author(string name, string description)
        {
            Name = name;
            Description = description;
            // _subscribers = [];
        }

        public static Author Create(string name, string description)
        {
            var author = new Author(name, description);
            return author;
        }

        public void Publish(Article article)
        {
            Article CreatedArticle = article.Create();
            var PublishedMessage = CreatedArticle.ToString();
            OnPublish?.Invoke(this, new MessageEventargs() { Message = PublishedMessage });
            // _subscribers?.ForEach(subscriber => subscriber.Notify(PublishedMessage));
        }

        // public void AddSubcriber(ISubscriber subscriber)
        // {
        //     _subscribers?.Add(subscriber);
        // }

        // public void RemoveSubcriber(ISubscriber subscriber)
        // {
        //     _subscribers?.Remove(subscriber);
        // }


    }
}