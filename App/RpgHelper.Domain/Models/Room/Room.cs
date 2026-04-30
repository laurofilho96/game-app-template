using Domain.Models.Users;

namespace Domain.Models.Room;

public class Room
{
    public Guid RoomId { get; set; }
    public required string RoomTitle { get; set; }
    public required string RoomSystem { get; set; }
    public string? RoomDescription { get; set; }
    public string? RoomPassword { get; set; }
    public required List<Master> Gms { get; set; }
    public List<Player>? Players { get; set; }
    public required List<Act> Acts { get; set; }
    public required CampaignConfigures CampaignConfigures { get; set; }
}
