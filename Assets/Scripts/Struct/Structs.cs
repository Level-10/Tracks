using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct ItemsStruct
{
    [SerializeField] string itemName;
    [SerializeField] int itemNb;

    //get set
    public string ItemName { get { return itemName; } set { itemName = value; } }
    public int ItemNb { get { return itemNb; } set { itemNb = value; } }

    //Init
    public ItemsStruct(string _itemName, int _itemNb)
    {
        itemName = _itemName;
        itemNb = _itemNb;
    }
}

public static class Structs 
{
    
}
