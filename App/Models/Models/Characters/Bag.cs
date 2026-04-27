using Domain.Models.Items;

namespace Domain.Models.Characters;

public class Bag
{
    public int BagId { get; set; }
    public int CharacterId { get; set; }
    public string UserId { get; set; }
    public int EquipmentCount { get; set; }
    public int ItemCount { get; set; }
    public List<Item> Consumables { get; set; }
    public List<Equipment> Equipments { get; set; }
    public List<Item> KeyItems { get; set; }
}
