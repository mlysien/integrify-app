namespace Integrify.Shared.Abstractions.Messaging;

[AttributeUsage(AttributeTargets.Class)]
public class MessageAttribute(string? module = null, bool enabled = true) : Attribute
{
    public string Module { get; } = module ?? string.Empty;
    public bool Enabled { get; } = enabled;
}