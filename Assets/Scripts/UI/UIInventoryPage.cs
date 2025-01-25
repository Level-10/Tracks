using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Sprite sprite;
    public int quantity;
    public string title, description;

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
            _uiItem.OnItemClicked   += HandleItemSelection;
            _uiItem.OnItemBeginDrag += HandleBeginDrag;
            _uiItem.OnItemDroppedOn += HandleSwap;
            _uiItem.OnItemEndDrag   += HandleEndDrag;
            _uiItem.OnRightMouseBtnClicked += HandleShowItemActions;
        }
    }

    private void HandleShowItemActions(UIInventoryItem item)
    {
    }

    private void HandleEndDrag(UIInventoryItem item)
    {
        mouseFollower.Toggle(false);
    }

    private void HandleSwap(UIInventoryItem item)
    {
    }

    private void HandleBeginDrag(UIInventoryItem item)
    {
        mouseFollower.Toggle(true);
        mouseFollower.SetData(sprite, quantity);
    }

    private void HandleItemSelection(UIInventoryItem item)
    {
        itemDescription.SetDescription(sprite, title, description);
        listOfUIItems[0].Select();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        itemDescription.ResetDescription();

        listOfUIItems[0].SetData(sprite, quantity);
    }
    
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
