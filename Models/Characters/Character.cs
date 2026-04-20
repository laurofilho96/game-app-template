namespace Models.Characters;

public class Character
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public Race Race { get; set; }
    public Job Job { get; set; }
    
}
