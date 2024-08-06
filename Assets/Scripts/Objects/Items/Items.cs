using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypes
{
    // When use enum for chose th type, make a .ToString() for set litteral enum as a string
    SmallKey,
    GreyKey,
    GoldKey,
    Wrench,
    none
}

public class Items : Pickups
{
    [SerializeField] ItemTypes type = ItemTypes.none;

    public ItemTypes Type => type;

    protected override void Start()
    {
        base.Start();
        // Already invoke OnCatchItem
    }

    /*protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }*/

    protected override void AddItemToInventory()
    {
        //ItemsStruct _item = new ItemsStruct(keyType.ToString(), GetComponent<Pickups>());
        //WorldManager.Instance.MyInventory.AddItem(_type);
        WorldManager.Instance.OnItemCatch?.Invoke(type);
        //UIManager.Instance.InventoryUI.DrawItem(Type);
    }
}
