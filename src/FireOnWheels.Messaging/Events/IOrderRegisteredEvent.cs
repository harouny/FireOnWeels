namespace FireOnWheels.Messaging.Events
{
    public interface IOrderRegisteredEvent : IDomainEvent
    {
        int OrderId { get; set; }
    }
}
