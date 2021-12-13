using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{
    protected string _itemName;

    public string ItemName
    {
        get { return _itemName; }
        set
        {
            _itemName = value;
        }
    }
    protected Sprite itemSprite;

    public BaseItem(string itemName)
    {
        this._itemName = itemName;
    }
}
