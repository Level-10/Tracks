using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : Pickups
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) {
            inventory.AddKey(ItemTypes.wrench);
            Destroy(gameObject);
        }

    }
}
