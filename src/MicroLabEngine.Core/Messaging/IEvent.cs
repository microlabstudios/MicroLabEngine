public interface IEvent<TMetadata> where TMetadata : IEventMetadata
{
    TMetadata Metadata { get; }
}