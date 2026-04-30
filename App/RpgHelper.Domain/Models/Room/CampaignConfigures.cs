using Domain.Enums;

namespace Domain.Models.Room;

public class CampaignConfigures
{
    public WorldType WorldType { get; set; }
    public string? WorldName { get; set; }
    public int StartLevel { get; set; }
    public int MaxLevel { get; set; }
    public int LevelUpSystem { get; set; }
    public List<int>? ItemTypeRestrictions { get; set; }
    public List<int> LocationsIds { get; set; }
}
