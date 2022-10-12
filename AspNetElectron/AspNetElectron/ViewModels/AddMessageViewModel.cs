using System.ComponentModel.DataAnnotations;

namespace AspNetElectron.ViewModels;

public record AddMessageViewModel(
    [Required(ErrorMessage = "Не указан автор")] string Author, 
    [Required(ErrorMessage = "Не указан текст")] string Text
    );