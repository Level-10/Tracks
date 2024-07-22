using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UtilityItemsTypes
{
    // When use enum for chose th type, make a .ToString() for set litteral enum as a string
    Wrench
}

public class UtilityItems : Pickups
{
    [SerializeField] UtilityItemsTypes itemType = UtilityItemsTypes.Wrench;

    protected override void Start()
    {
        base.Start();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Set name par rapport à l'enum selectionné
            ItemsStruct _item = new ItemsStruct(itemType.ToString(), 1);
            Inventory.Instance.AddItem(_item);
            Destroy(gameObject);
        }

    }
}
