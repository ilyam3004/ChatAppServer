namespace ChatApp.Application.Models.Responses;

public record UserResponse(
    string UserId,
    string Username,
    string ConnectionId,
    string RoomId);