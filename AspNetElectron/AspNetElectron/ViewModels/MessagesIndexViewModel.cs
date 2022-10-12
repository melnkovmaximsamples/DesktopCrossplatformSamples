using AspNetElectron.Entities;

namespace AspNetElectron.ViewModels;

public record MessagesIndexViewModel(IEnumerable<MessageEntity> Messages);