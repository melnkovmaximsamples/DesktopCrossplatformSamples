using System.ComponentModel.DataAnnotations;

namespace ApiForReactElectron.ViewModels;

public record AddMessageViewModel(
    [Required(ErrorMessage = "Не указан автор")] string Author, 
    [Required(ErrorMessage = "Не указан текст")] string Text
    );