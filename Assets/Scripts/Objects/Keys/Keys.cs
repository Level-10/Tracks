using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyTypes
{
    // When use enum for chose th type, make a .ToString() for set litteral enum as a string
    SmallKey,
    MediumKey,
    GoldKey,
    key
}

public class Keys : Pickups
{
    [SerializeField] KeyTypes keyType = KeyTypes.key;

    protected override void Start()
    {
        base.Start();
    }

    /*protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }*/

    protected override void AddItemToInventory()
    {
        ItemsStruct _item = new ItemsStruct(keyType.ToString(), GetComponent<Pickups>());
        //Inventory.Instance.AddItem(_item);
    }
}
