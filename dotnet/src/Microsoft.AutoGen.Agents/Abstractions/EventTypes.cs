using Google.Protobuf.Reflection;

namespace Microsoft.AutoGen.Agents.Abstractions;
public sealed class EventTypes(TypeRegistry typeRegistry, Dictionary<string, Type> types, Dictionary<Type, HashSet<string>> eventsMap)
{
    public TypeRegistry TypeRegistry { get; } = typeRegistry;
    public Dictionary<string, Type> Types { get; } = types;
    public Dictionary<Type, HashSet<string>> EventsMap { get; } = eventsMap;
}