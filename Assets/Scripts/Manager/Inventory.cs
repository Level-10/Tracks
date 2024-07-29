using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    /*[SerializeField] int smallKeysCount = 0;
    [SerializeField] int greyKeysCount = 0;
    [SerializeField] int goldKeysCount = 0;
    [SerializeField] int WrenchesCount = 0;*/

    [SerializeField] List<ItemsStruct> pickups = new List<ItemsStruct>();

    Dictionary<string, ItemsStruct> Items = new Dictionary<string, ItemsStruct>();
    
    public List<ItemsStruct> Pickups => pickups;

    void Start()
    {
        WorldManager.Instance.MyInventory = this;
    }

    void Update()
    {
        
    }

    public void AddItem(ItemsStruct _item)
    {
        Debug.Log("Enter function");
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
        /*if (_index == ItemTypes.smallKey) smallKeysCount++;
        else if (_index == ItemTypes.greyKey) greyKeysCount++;
        else if (_index == ItemTypes.goldKey) goldKeysCount++;
        else if (_index == ItemTypes.wrench) WrenchesCount++;*/
    }

    void DictionnaryAdd()
    {
        //Items.Add("Wrench", new ItemsStruct("Wrench", );
    }


}
