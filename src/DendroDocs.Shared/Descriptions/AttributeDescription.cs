using DendroDocs.Json;

namespace DendroDocs;

[DebuggerDisplay("Attribute {Type} {Name}")]
public class AttributeDescription(string? type, string? name)
{
    public string Type { get; } = type ?? throw new ArgumentNullException(nameof(type));

    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    [JsonProperty(ItemTypeNameHandling = TypeNameHandling.None)]
    [JsonConverter(typeof(ConcreteTypeConverter<List<AttributeArgumentDescription>>))]
    public List<AttributeArgumentDescription> Arguments { get; } = [];
}
