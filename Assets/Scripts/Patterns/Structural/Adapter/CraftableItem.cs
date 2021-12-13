using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftableItem : BaseItem, ICraftable
{
    public CraftableItem(string itemName) : base(itemName)
    {
    }

    public BaseItem Craft()
    {
        Debug.Log("Crafting Item");
        return new CraftableItem(ItemName + " - Crafted");
    }
}
