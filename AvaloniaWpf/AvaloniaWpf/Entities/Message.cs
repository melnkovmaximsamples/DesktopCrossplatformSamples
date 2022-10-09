using System;

namespace AvaloniaWpf.Entities;

public record Message(Guid Id, string Author, string Text): IEntity
{
    public Message() : this(default, string.Empty, string.Empty){}
}