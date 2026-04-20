using Models.Characters;

namespace Models.Users;

public class Player : User
{
    public int PlayerId { get; set; }
    public required string Nickname { get; set; }
    public List<Playable>? Characters { get; set; }

}
