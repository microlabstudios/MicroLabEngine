namespace MicroLabEngine.Core.Messaging;

public static class EventPublisher<TEventType>
{
    public delegate void Message(TEventType eventData);
    private static event Message? OnEventPublished;

    public static void PublishEvent(TEventType eventData)
    {
        if (OnEventPublished != null)
        {
            OnEventPublished.Invoke(eventData);
        }
    }

    public static void Subscribe(Message handler)
    {
        OnEventPublished += handler;
    }

    public static void Unsubscribe(Message handler)
    {
        OnEventPublished -= handler;
    }
}