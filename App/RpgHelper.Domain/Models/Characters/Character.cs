namespace Domain.Models.Characters;

public class Character
{
    public int CharacterId { get; set; }
    public required string Name { get; set; }
    public string? Portrait { get; set; }
    public required string Description { get; set; }
    public Race Race { get; set; }
    public Job Job { get; set; }
    public int ExperiencePoints { get; set; }
    public int HealthPoints { get; set; }
    public int ActionPoints { get; set; }
    public decimal AttackPoints { get; set; } 
    public decimal DefensePoints { get; set; }
    public decimal DexterityPoints { get; set; }
    public decimal EvadePoints { get; set; }
    
}
