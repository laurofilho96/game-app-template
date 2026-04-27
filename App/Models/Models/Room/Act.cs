using Domain.Models.Characters;

namespace Domain.Models.Room;

public class Act
{
    public Guid ActId { get; set; }
    public required string ActName { get; set; }
    public int ActNumber { get; set; }
    public string? ActDescription { get; set; }
    public string? ActResult { get; set; }
    public List<Enemy>? ActEnemies { get; set; }
    public List<Character> Characters { get; set; }
}
