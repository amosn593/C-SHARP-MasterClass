using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAndDelegates.Models;

namespace EventsAndDelegates.Interfaces
{
    public class MessageEventargs : EventArgs
    {
        public required String Message { get; set; }
    }
    public interface IPublisher
    {
        event EventHandler<MessageEventargs>? OnPublish;
        //void AddSubcriber(ISubscriber subscriber);
        //void RemoveSubcriber(ISubscriber subscriber);
        void Publish(Article article);
    }
}