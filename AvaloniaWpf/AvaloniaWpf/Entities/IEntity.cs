using System;

namespace AvaloniaWpf.Entities;

public interface IEntity
{
    Guid Id { get; init; }
}