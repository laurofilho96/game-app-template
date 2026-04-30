using Domain.Models.Characters;

namespace Domain.Models.Users;

public class Player : User
{
    public Player(string nickname)
    {
        PlayerId = Guid.NewGuid().ToString();
        Nickname = nickname;
        Characters = new List<Playable>();
    }

    public string PlayerId { get; set; }
    public required string Nickname { get; set; }
    public List<Playable>? Characters { get; set; }
}
