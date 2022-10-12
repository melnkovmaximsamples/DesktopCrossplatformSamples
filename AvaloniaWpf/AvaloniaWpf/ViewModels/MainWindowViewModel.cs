using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AvaloniaWpf.Entities;
using AvaloniaWpf.Models;
using AvaloniaWpf.Repositories;
using DynamicData;
using ReactiveUI;

namespace AvaloniaWpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRepository<MessageEntity> _messageRepository;
        public ObservableCollection<MessageEntity> Messages { get; init; }
        public MainWindowCommands Commands { get; init; }

        public MainWindowViewModel()
        {
            _messageRepository = IoC.Resolve<IRepository<MessageEntity>>();
            Messages = new ObservableCollection<MessageEntity>();
            Commands = new MainWindowCommands()
            {
                CreateMessageCommand = ReactiveCommand.Create(CreateMessage),
                RemoveMessageCommand = ReactiveCommand.Create<MessageEntity>(RemoveMessage),
                ClearMessagesCommand = ReactiveCommand.Create(ClearMessages),
                SaveToDbCommand = ReactiveCommand.CreateFromTask(SaveToDb),
                LoadFromDbCommand = ReactiveCommand.CreateFromTask(LoadFromDb)
            };
        }

        private void CreateMessage() => Messages.Add(new MessageEntity() { Id = Guid.NewGuid() });
        private void RemoveMessage(MessageEntity message) => Messages.Remove(message);
        private void ClearMessages() => Messages.Clear();
        private async Task SaveToDb()
        {
            await _messageRepository.RemoveAllAsync();
            await _messageRepository.AddRangeAsync(Messages);
        }

        private async Task LoadFromDb()
        {
            Messages.Clear();

            var newMessages = await _messageRepository.GetAllAsync();
            
            Messages.AddRange(newMessages);
        }
    }
}