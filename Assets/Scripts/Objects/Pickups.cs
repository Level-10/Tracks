using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Pickups : MonoBehaviour
{
    [SerializeField] protected Collider2D boxCollider = null;
    [SerializeField] protected Old.Inventory inventory = null;
    protected virtual void Start()
    {
        inventory = FindObjectOfType<Old.Inventory>();
        boxCollider = GetComponent<Collider2D>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag(WorldManager.PLAYER))
        if(collision.GetComponent<Player>())
        {
            if (WorldManager.Instance.MyInventory.Pickups.Count == 4) return;
            AddItemToInventory();
            //Debug.Log("Trigger Enter");
        }
        Destroy(gameObject);
    }

    protected virtual void AddItemToInventory() { 
        
    }
}
