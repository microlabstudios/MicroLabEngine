public interface IEventMetadata
{
    Dictionary<string, Tuple<object, Type>> Values { get; }

    void SetValue<T>(string key, Tuple<object, Type> value);
    Tuple<object, Type> GetValue(string key);
}