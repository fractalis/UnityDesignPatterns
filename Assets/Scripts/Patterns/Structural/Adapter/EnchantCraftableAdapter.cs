using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnchantCraftableAdapter : IEnchantable
{
    private CraftableItem craftableItem;

    public EnchantCraftableAdapter(CraftableItem craftableItem)
    {
        this.craftableItem = craftableItem;
    }

    public BaseItem Enchant()
    {
        var newItem = this.craftableItem.Craft();
        return new EnchantableItem(newItem.ItemName + " - Enchanted");
    }
}
