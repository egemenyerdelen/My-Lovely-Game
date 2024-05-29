using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")] 
public class Equipment : Item
{
    public EquipmentSlot equipSlot;
    
    [SerializeField] private int damageModifier;
    [SerializeField] private int armorModifier;

    public override void Use()
    {
        base.Use();
        EquipmentManager.Instance.Equip(this);
        RemoveFromInventory();
    }
}

public enum EquipmentSlot { Head, Chest, Legs, Feet, Weapon, Shield }