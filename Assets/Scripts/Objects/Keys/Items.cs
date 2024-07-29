using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypes
{
    // When use enum for chose th type, make a .ToString() for set litteral enum as a string
    SmallKey,
    MediumKey,
    GoldKey,
    Wrench,
    none
}

public class Items : Pickups
{
    [SerializeField] ItemTypes Type = ItemTypes.none;

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
        WorldManager.Instance.MyInventory.Pickups.Add(Type);
        //ItemsStruct _item = new ItemsStruct(keyType.ToString(), GetComponent<Pickups>());
        //Inventory.Instance.AddItem(_item);
    }
}
