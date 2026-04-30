using Domain.Models.Characters;
using Domain.Models.Items;

namespace Domain.Models.Room;

public class Location
{
    public int LocationId { get; set; }
    public string LocationName { get; set; }
    public int LocationRecommendedLevel { get; set; }
    public string LocationDescription { get; set; }
    public LocationType Type { get; set; }
    public List<Item> Loots { get; set; }
    public List<Enemy> Enemies { get; set; } 
}

public enum LocationType
{
    City = 0,
    Dungeon = 1,
    Field = 2,
    Wasteland = 3,
    Dessert = 4
}
