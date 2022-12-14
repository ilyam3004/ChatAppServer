using ChatApp.Domain.Entities;

namespace ChatApp.Application.Common.Interfaces.Persistence;

public interface IMessageRepository
{
    Task<Message> SaveMessage(Message message);
    Task<bool> RemoveMessageById(string messageId);
    Task<bool> RemoveAllMessagesFromRoom(string roomId);
}