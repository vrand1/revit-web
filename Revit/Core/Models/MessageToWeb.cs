namespace Core.Models;

public sealed class MessageToWeb
{
    public string Title { get; set; }
    public string Message { get; set; }
    
    public MessageToWeb(string title, string message)
    {
        Title = title;
        Message = message;
    }
}