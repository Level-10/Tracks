using System;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.UI
{
    public class UIInventoryPage : MonoBehaviour
    {
        // Ref to item prefab
        [SerializeField] UIInventoryItem itemPrefab;
        // Ref to direct transform which is the content of our inventory panel
        [SerializeField] RectTransform contentPanel;
        // Ref to inventory description
        [SerializeField] UIInventoryDescription itemDescription;
        [SerializeField] MouseFollower mouseFollower;
        // Store the indices of each item of UI
        List<UIInventoryItem> listOfUIItems = new List<UIInventoryItem>();

        int currentlyDraggedItemIndex = -1;
        // Left clic for display informations, Right for actions, last for drag
        public event Action<int> OnDescriptionRequested, OnItemActionRequested, OnStartDragging;
        // Take te two index from the listOfUIItems for exchange when end drag
        public event Action<int, int> OnSwapItems;

        private void Awake()
        {
            //Automaticly hide if active in editor
            Hide();
            mouseFollower.Toggle(false);
            itemDescription.ResetDescription();
        }

        public void InitializeInventoryUI(int _inventorySize)
        {
            for (int i = 0; i < _inventorySize; i++)
            {
                //Create uiItem using prefab, set contentPanel as transform parent, add item to the list
                UIInventoryItem _uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
                _uiItem.transform.SetParent(contentPanel);
                listOfUIItems.Add(_uiItem);
                _uiItem.OnItemClicked += HandleItemSelection;
                _uiItem.OnItemBeginDrag += HandleBeginDrag;
                _uiItem.OnItemDroppedOn += HandleSwap;
                _uiItem.OnItemEndDrag += HandleEndDrag;
                _uiItem.OnRightMouseBtnClicked += HandleShowItemActions;
            }
        }

        private void HandleShowItemActions(UIInventoryItem inventoryItemUI)
        {

        }

        //Called from inventory controller to update the data of one of the ui items
        public void UpdateData(int _itemIndex, Sprite _itemImage, int _itemQuantity)
        {
            // If count is greater than index means that we have item on our list
            if (listOfUIItems.Count > _itemIndex)
            {
                //Acces to item set data
                listOfUIItems[_itemIndex].SetData(_itemImage, _itemQuantity);
            }

        }

        private void HandleEndDrag(UIInventoryItem inventoryItemUI)
        {
            ResetDraggedItem();
        }

        private void HandleSwap(UIInventoryItem inventoryItemUI)
        {
            int _index = listOfUIItems.IndexOf(inventoryItemUI);
            if (_index == -1) return;

            OnSwapItems?.Invoke(currentlyDraggedItemIndex, _index);
        }

        private void ResetDraggedItem()
        {
            mouseFollower.Toggle(false);
            currentlyDraggedItemIndex = -1;
        }

        private void HandleBeginDrag(UIInventoryItem inventoryItemUI)
        {
            int _index = listOfUIItems.IndexOf(inventoryItemUI);
            // if no reference of the object, return
            if (_index == -1) return;
            currentlyDraggedItemIndex = _index;
            // Select the item
            HandleItemSelection(inventoryItemUI);
            OnStartDragging?.Invoke(_index);
        }

        public void CreateDraggedItem(Sprite _sprite, int _quantity)
        {
            mouseFollower.Toggle(true);
            mouseFollower.SetData(_sprite, _quantity);
        }

        private void HandleItemSelection(UIInventoryItem _inventoryItemUI)
        {
            //if selected and is in the list, see description by index
            int _index = listOfUIItems.IndexOf(_inventoryItemUI);
            if (_index == -1) return;
            OnDescriptionRequested?.Invoke(_index);
            Debug.Log("Description request invoke");
        }

        public void Show()
        {
            gameObject.SetActive(true);
            ResetSelection();
        }

        public void ResetSelection()
        {
            itemDescription.ResetDescription();
            DeselectAllItems();
        }

        private void DeselectAllItems()
        {
            foreach (UIInventoryItem _item in listOfUIItems)
            {
                _item.Deselect();
            }
        }

        public void Hide()
        {
            gameObject.SetActive(false);
            ResetDraggedItem();
        }

        internal void UpdateDescription(int _itemIndex, Sprite _itemImage, string _name, string _description)
        {
            itemDescription.SetDescription(_itemImage, _name, _description);
            DeselectAllItems();
            // Select to show border
            listOfUIItems[_itemIndex].Select();
        }
    }
}