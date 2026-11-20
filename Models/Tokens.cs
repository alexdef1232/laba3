namespace labs3.Models;
public abstract class Tokens
{
    public string Value { get; }

    protected Tokens(string value)
    {
        Value = value ?? throw new System.ArgumentNullException(nameof(value));
    }

    public override string ToString() => Value;
}