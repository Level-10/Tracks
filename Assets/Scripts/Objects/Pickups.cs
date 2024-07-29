using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Pickups : MonoBehaviour
{
    [SerializeField] protected Collider2D boxCollider = null;
    [SerializeField] protected Inventory inventory = null;
    protected virtual void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        boxCollider = GetComponent<Collider2D>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AddItemToInventory();
            WorldManager.Instance.OnItemCatch.Invoke();
        }
        Destroy(gameObject);
    }

    protected virtual void AddItemToInventory() { 
        
    }
}
