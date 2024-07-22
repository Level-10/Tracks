using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypes
{
    // When use enum for chose th type, make a .ToString() for set litteral enum as a string
    SmallKey,
    MediumKey,
    GoldKey,
    key
}

public class Keys : Pickups
{
    [SerializeField] ItemTypes keyType = ItemTypes.key;

    protected override void Start()
    {
        base.Start();
    }


    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Player _player = collision.GetComponent<Player>();
            // Set name par rapport à l'enum selectionné
            ItemsStruct _item = new ItemsStruct(keyType.ToString(), 1);
            Inventory.Instance.AddItem(_item);
            Destroy(gameObject);
        }
    }
}
