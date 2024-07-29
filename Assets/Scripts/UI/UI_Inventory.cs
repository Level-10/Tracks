using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    
    [SerializeField] List<ItemsStruct> items = null;

    [SerializeField] Inventory inventoryRef = null;
    [SerializeField] GameObject UI_Item = null;

    void Start()
    {
        // Recup in Resources folder by Path
        UI_Item = Resources.Load("Prefabs/UI/UI_Item") as GameObject;
        Init();
    }

    void Update()
    {
        if (inventoryRef == null)
            GetInventoryRef();
    }

    void Init()
    {
        WorldManager.Instance.OnItemCatch += DrawInventory;
    }

    void GetInventoryRef()
    {
            inventoryRef = WorldManager.Instance.MyInventory;
    }

    void DrawInventory()
    {
        
        Debug.Log("Item catch !");
        //Update List
    }
    // for each items dans la liste d'inventaire : Draw une image cliquable
    // Faire un event quand je ramasse un objet pour update l'UI

    void TestDraw()
    {
        Instantiate(UI_Item, this.transform);
    }
}
