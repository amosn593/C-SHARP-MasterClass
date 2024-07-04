using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAndDelegates.Interfaces;

namespace EventsAndDelegates.Models
{
    public record User : DomainEntity, ISubscriber
    {
        public string Name { get; init; }

        public User(string name)
        {
            Name = name;
        }
        public void Notify(string message)
        {
            Console.WriteLine($"User Id : {Id}, Message: {message}");
            Console.WriteLine();
        }

        public void Subscribe(IPublisher publisher)
        {
            publisher.OnPublish += (sender, e) => Notify(e.Message);
        }

        public void Unsubscribe(IPublisher publisher)
        {
            publisher.OnPublish -= (sender, e) => Notify(e.Message);
        }
    }
}