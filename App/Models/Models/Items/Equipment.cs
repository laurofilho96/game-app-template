namespace Domain.Models.Items;

public class Equipment : Item
{
    public EquipmentType Type { get; set; }
    public BodyPart BodyPart { get; set; }
    public WeaponType WeaponType { get; set; }

    //Dap | Dep
    public float DamagePoints { get; set; }
    public float DefensePoints { get; set; }

}

public enum EquipmentType
{
    Armor,
    Weapon
}

public enum BodyPart
{
    None = 0,
    Head = 1,
    Chest = 2,
    Arms = 3,
    Legs = 4,
    Foots = 5,
    Hands = 6
}

public enum WeaponType
{
    None = 0,
    Sword = 1,
    Mace = 2,
    Stick = 3,
    Bow = 4,
    Spear = 5,
    GreatSword = 6,
    Knife = 7,
    Staff = 8,
    CrossBow = 9,
    Other = 10
}
