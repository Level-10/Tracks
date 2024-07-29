using System;
using UnityEngine;

public class WorldManager : Singleton<WorldManager>
{
    #region Events
    public Action OnItemCatch;
    #endregion Events

    [SerializeField] Inventory inventory = null;

    public Inventory MyInventory { get => inventory;  set => inventory = value; }

    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        
    }
}
