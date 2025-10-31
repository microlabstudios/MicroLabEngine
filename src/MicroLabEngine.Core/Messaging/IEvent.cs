namespace MicroLabEngine.Core.Messaging;

public interface IEvent<TMetadata> where TMetadata : IEventMetadata
{
    TMetadata Metadata { get; }
}