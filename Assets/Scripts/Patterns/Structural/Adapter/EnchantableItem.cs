using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnchantableItem : BaseItem, IEnchantable
{
    public EnchantableItem(string itemName) : base(itemName)
    {
    }

    public BaseItem Enchant()
    {
        Debug.Log("Enchanting item");
        return new EnchantableItem(ItemName + " - Enchanted");
    }
}
