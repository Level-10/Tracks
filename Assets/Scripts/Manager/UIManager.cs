using System;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public Action OnDrawInventory = null;

    [SerializeField] UI_Inventory inventoryUI = null;

    public UI_Inventory InventoryUI => inventoryUI;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        
    }
} 
