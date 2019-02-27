using System;
using System.Collections.Generic;
using DDD.Example.LightShop.OrderContext.DomainEvents;

namespace DDD.Example.LightShop.SharedKernel
{
    public interface IAggregateRoot<TDomainEvent>
    {
        Guid Id { get; }
        Queue<TDomainEvent> UncommittedEvents { get; }
        void ApplyChange(TDomainEvent @event);
        void Commit();
    }
}