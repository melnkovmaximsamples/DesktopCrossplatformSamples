using AspNetElectron.Entities;
using AspNetElectron.Repositories;
using AspNetElectron.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetElectron.Controllers;

public class MessagesController: Controller
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
        
        return View(viewModel);
    }

    [HttpGet("/new")]
    public IActionResult AddMessage()
    {
        return View();
    }

    [HttpPost("/new")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddMessage(MessageEntity message)
    {
        await _messageRepository.AddAsync(message);
        
        return RedirectToAction("GetAllMessages");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveAllMessages()
    {
        await _messageRepository.RemoveAllAsync();
        
        return RedirectToAction("GetAllMessages");
    }
}