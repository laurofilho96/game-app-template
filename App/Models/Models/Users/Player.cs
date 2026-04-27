using Domain.Models.Characters;

namespace Domain.Models.Users;

public class Player : User
{
    public string PlayerId { get; set; }
    public required string Nickname { get; set; }
    public List<Playable>? Characters { get; set; }
}
