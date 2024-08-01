using System;
using UnityEngine;

public class WorldManager : Singleton<WorldManager>
{
    #region Events
    public Action OnItemCatch;
    #endregion Events
    #region Tags
    public static readonly string PLAYER = "Player";
    public static readonly string PICKUPS = "Pickups";
    #endregion Tags

    [SerializeField] Inventory inventory = null;

    public Inventory MyInventory { get => inventory;  set => inventory = value; }

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
