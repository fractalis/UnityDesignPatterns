using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterDemo : MonoBehaviour
{
    public void OnRun()
    {
        CraftableItem craftedSword = new CraftableItem("Sword");
        EnchantCraftableAdapter ecAdapter = new EnchantCraftableAdapter(craftedSword);

        var enchantedCraftedSword = ecAdapter.Enchant();

        Debug.Log(enchantedCraftedSword.ItemName);
    }
}
