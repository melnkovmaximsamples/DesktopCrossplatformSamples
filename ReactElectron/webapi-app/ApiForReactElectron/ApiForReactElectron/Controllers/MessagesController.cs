using ApiForReactElectron.Entities;
using ApiForReactElectron.Repositories;
using ApiForReactElectron.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetElectron.Controllers;

[Route("[controller]")]
public class MessagesController: ControllerBase
{
    private readonly IRepository<MessageEntity> _messageRepository;

    public MessagesController(IRepository<MessageEntity> messageRepository)
    {
        _messageRepository = messageRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllMessages()
    {
        var messages = await _messageRepository.GetAllAsync();
        var viewModel = new MessagesIndexViewModel(messages);
        
        return Ok(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddMessage([FromBody] AddMessageViewModel request)
    {
        var messageEntity = new MessageEntity()
        {
            Author = request.Author,
            Text = request.Text
        };
        await _messageRepository.AddAsync(messageEntity);
        
        return RedirectToAction("GetAllMessages");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAllMessages()
    {
        await _messageRepository.RemoveAllAsync();
        
        return RedirectToAction("GetAllMessages");
    }
}