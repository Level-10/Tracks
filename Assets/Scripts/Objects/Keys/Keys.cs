using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : Pickups
{
    [SerializeField] bool smallKey = false;
    [SerializeField] bool greyKey = false;
    [SerializeField] bool goldKey = false;

    protected override void Start()
    {
        base.Start();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Player _player = collision.GetComponent<Player>();
            AddItem();
            Destroy(gameObject);
        }
    }

    void AddItem()
    {
        if (smallKey) inventory.AddKey(ItemTypes.smallKey);
        else if (greyKey) inventory.AddKey(ItemTypes.greyKey);
        else if (goldKey) inventory.AddKey(ItemTypes.goldKey);
    }
}
