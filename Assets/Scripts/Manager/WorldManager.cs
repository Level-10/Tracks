using System;
using UnityEngine;

public class WorldManager : Singleton<WorldManager>
{
    #region Events
    public Action<ItemTypes> OnItemCatch;
    public Action<GameObject> OnItemDrop;
    #endregion Events
    //#region Tags
    //public static readonly string PLAYER = "Player";
    //public static readonly string PICKUPS = "Pickups";
    //#endregion Tags

    [SerializeField] Old.Inventory inventory = null;

    public Old.Inventory MyInventory { get => inventory;  set => inventory = value; }

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
