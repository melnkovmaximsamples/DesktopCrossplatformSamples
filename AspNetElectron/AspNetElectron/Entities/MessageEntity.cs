namespace AspNetElectron.Entities;

public record MessageEntity(Guid Id, string Author, string Text): IEntity
{
    public MessageEntity() : this(default, string.Empty, string.Empty){}
}