using System.Windows.Input;

namespace AvaloniaWpf.Models;

public class MainWindowCommands
{
    public ICommand CreateMessageCommand { get; init; } = null!;
    public ICommand RemoveMessageCommand { get; init; } = null!;
    public ICommand ClearMessagesCommand { get; init; } = null!;
    public ICommand SaveToDbCommand { get; init; } = null!;
    public ICommand LoadFromDbCommand { get; init; } = null!;
}