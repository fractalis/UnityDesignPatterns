using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterDemo : MonoBehaviour
{
    public void OnRun()
    {
        CraftableItem craftedSword = new CraftableItem("Sword");
        EnchantCraftableAdapter ecAdapter = new EnchantCraftableAdapter(craftedSword);

        EnchantableItem enchantedCraftedSword = ecAdapter.Enchant() as EnchantableItem;

        Debug.Log(enchantedCraftedSword.ItemName);
    }
}
