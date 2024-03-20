namespace Integrify.Shared.Abstractions.Modules;

/// <summary>
/// Interface for communication between modules
/// </summary>
public interface IModuleClient
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path">Endpoint where request will be sent</param>
    /// <param name="request">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task SendAsync(string path, object request, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TResult"></typeparam>
    /// <returns></returns>
    Task<TResult> SendAsync<TResult>(string path, object request, CancellationToken cancellationToken = default)
        where TResult : class;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    Task PublishAsync(object message, CancellationToken cancellationToken = default);
}