namespace DendroDocs;

[DebuggerDisplay("IfElse {Condition}")]
public class IfElseSection : Statement
{
    public string? Condition { get; set; }
}
