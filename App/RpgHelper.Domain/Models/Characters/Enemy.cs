using Domain.Models.Items;

namespace Domain.Models.Characters;

public class Enemy : Character
{
    public int Experience { get; set; }
    public List<Item> Loot { get; set; }
}
