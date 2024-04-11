namespace Integrify.Shared.Abstractions.Plugins;

/// <summary>
/// Represents inbound type plugin
/// </summary>
public interface IInboundPlugin : IPlugin
{
    Task<IEnumerable<object>> FetchAsync();
}