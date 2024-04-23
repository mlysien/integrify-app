using System.ComponentModel.DataAnnotations;

namespace Plugins.Inbounds.Example.Port.Dto;

public record CustomerDto(Guid Id, string Name);