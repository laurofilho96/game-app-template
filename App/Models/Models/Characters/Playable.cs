namespace Domain.Models.Characters;

public class Playable : Character
{
    public int CharacterId { get; set; }
    public string UserId { get; set; }
    public int BagId { get; set; }
}
