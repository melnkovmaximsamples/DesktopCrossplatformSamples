using ApiForReactElectron.Entities;

namespace ApiForReactElectron.ViewModels;

public record MessagesIndexViewModel(IEnumerable<MessageEntity> Messages);