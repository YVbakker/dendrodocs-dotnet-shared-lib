namespace DendroDocs;

public interface IParameterDescription
{
    string Type { get; }

    string Name { get; }

    bool HasDefaultValue { get; }

    List<IAttributeDescription> Attributes { get; }
}
