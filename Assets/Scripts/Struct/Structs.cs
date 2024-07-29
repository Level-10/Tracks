using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public struct ItemsStruct
{
    [SerializeField] string itemName;
    [SerializeField] Pickups itemScript;

    //get set
    public string ItemName { get { return itemName; } set { itemName = value; } }
    public Pickups ItemScript { get { return itemScript; } set { itemScript = value; } }

    //Init
    public ItemsStruct(string _itemName, Pickups _itemScript)
    {
        itemName = _itemName;
        itemScript = _itemScript;
    }
}

/*public struct ItemsWImageStruct
{
    [SerializeField] string itemName;
    [SerializeField] Image itemImage;

    public string ItemName { get { return itemName; } set { itemName = value; } }
    public Image ItemImage { get { return itemImage; } set { itemImage = value; } }

    public ItemsWImageStruct(string  _itemName, Image _itemImage)
    {
        itemName = _itemName;
        itemImage = _itemImage;
    }
}*/

public static class Structs 
{
    
}
