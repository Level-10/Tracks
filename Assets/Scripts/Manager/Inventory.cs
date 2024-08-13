using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    /*[SerializeField] int smallKeysCount = 0;
    [SerializeField] int greyKeysCount = 0;
    [SerializeField] int goldKeysCount = 0;
    [SerializeField] int WrenchesCount = 0;*/

    [SerializeField] List<ItemTypes> pickups = new List<ItemTypes>();
    [SerializeField] List<GameObject> pickupsGo = new List<GameObject>();
    
    public List<ItemTypes> Pickups => pickups;
    public List<GameObject> PickupsGo => pickupsGo;

    void Start()
    {
        WorldManager.Instance.MyInventory = this;
    }

    void Update()
    {
        
    }

    void Init()
    {
        WorldManager.Instance.OnItemCatch += AddItemToInventory; // don't work ? 
    }

    public void AddItemToInventory(ItemTypes _type)
    {
        pickups.Add(_type);
    }
    
    public void AddItemToInventory(GameObject _object)
    {
        pickupsGo.Add(_object);
    }

    public void RemoveItemFromInventory(ItemTypes _type)
    {
        pickups.Remove(_type);
    }
    
    public void RemoveItemFromInventory(GameObject _object)
    {
        pickupsGo.Remove(_object);
    }

    /*public void AddItem(ItemsStruct _item)
    {
        int _size = pickups.Count;
        if (_size <= 0) {
            pickups.Add(_item);
            Debug.Log("Size <= 0, addItem");
            return;
        }

        for (int i = 0; i < _size; i++) {
            if (pickups[i].ItemName == _item.ItemName)
            {
                // If find an item, increment his nb
                //_item =  new ItemsStruct(_item.ItemName, _item.ItemNb + pickups[i].ItemNb);
                return;
            } else
            {
                // If not find item, add item
                pickups.Add(_item);
            }
        }
    }*/

    /*if (_index == ItemTypes.smallKey) smallKeysCount++;
    else if (_index == ItemTypes.greyKey) greyKeysCount++;
    else if (_index == ItemTypes.goldKey) goldKeysCount++;
    else if (_index == ItemTypes.wrench) WrenchesCount++;*/


}
