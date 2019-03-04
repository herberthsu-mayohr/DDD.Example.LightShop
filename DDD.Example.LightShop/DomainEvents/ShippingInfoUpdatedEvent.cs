using System;
using DDD.Example.LightShop.SharedKernel;

namespace DDD.Example.LightShop.DomainEvents
{
    public class ShippingInfoUpdatedEvent : IDomainEvent
    {
        public ShippingInfoUpdatedEvent(Guid orderId, string contactName, string contactPhone, string shippingAddress)
        {
            EventId = Guid.NewGuid();
            OccuredOn = DateTime.Now;
            AggregateRootId = orderId;
            ContactName = contactName;
            ContactPhone = contactPhone;
            ShippingAddress = shippingAddress;
        }

        public Guid EventId { get; }
        public Guid AggregateRootId { get; }
        public string ContactName { get; }
        public string ContactPhone { get; }
        public string ShippingAddress { get; }
        public DateTime OccuredOn { get; }
    }
}