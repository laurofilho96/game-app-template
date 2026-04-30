namespace Domain.Models.Items;

public class Item
{
    public int Id { get; set; }
    public string Image { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public Effect Effect { get; set; }
    public int EffectPoints { get; set; }
    public int Rarity { get; set; }
}
