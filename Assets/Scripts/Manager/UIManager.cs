using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] UI_Inventory inventoryUI = null;

    public UI_Inventory InventoryUI => inventoryUI;

    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        
    }
} 
