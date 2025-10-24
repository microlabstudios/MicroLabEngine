public static class EventPublisher<TEventType>
{
    private delegate void EventHandler();
    private static event EventHandler OnEventPublished;

    public static void PublishEvent()
    {
        if (OnEventPublished != null)
        {
            OnEventPublished.Invoke();
        }
    }
}