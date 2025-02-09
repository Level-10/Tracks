using System;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu]
    public class InventorySO : ScriptableObject
    {
        //Inventory needs to know how many items we have and current state of an item
        [SerializeField] List<InventoryItem> inventoryItems;
        //Property, want to get but no to modify by any other class
        [field: SerializeField] public int Size { get; private set; } = 10;

        public void Initialize() // Init at start of the game
        {
            inventoryItems = new List<InventoryItem>();
            for (int i = 0; i < Size; i++)
            {
                // Create empty for size of the inventory
                inventoryItems.Add(InventoryItem.GetEmptyItem());
            }
        }

        public void AddItem(ItemSO _item, int _quantity)
        {
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if (inventoryItems[i].IsEmpty)
                {
                    inventoryItems[i] = new InventoryItem
                    {
                        item = _item,
                        quantity = _quantity
                    };
                }
            }

        }

        public Dictionary<int, InventoryItem> GetCurrentInventoryState()
        {
            // if we dont pass in the dictionary, the item is empty, for only update desired item and leave the rest in ui
            // Dictionary used for update Inventory UI through Inventory Controller
            Dictionary<int, InventoryItem> _returnValue = new Dictionary<int, InventoryItem>();

            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if (inventoryItems[i].IsEmpty) continue;
                _returnValue[i] = inventoryItems[i];
            }
            return _returnValue;
        }

        public InventoryItem GetItemAt(int _itemIndex)
        {
            Debug.Log("Item get");
            return inventoryItems[_itemIndex];
        }
    }

    [Serializable]
    public struct InventoryItem
    {
        public int quantity;
        public ItemSO item;
        public bool IsEmpty => item == null;

        public InventoryItem ChangeQuantity(int _newQuantity)
        {
            return new InventoryItem //return values of item too
            {
                item = this.item,
                quantity = _newQuantity
            };
        }

        public static InventoryItem GetEmptyItem() => new InventoryItem // Lambda used
        {
            item = null,
            quantity = 0
        };
    }
}
