using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    
    [SerializeField] List<ItemsStruct> items = null;
    //[SerializeField] List<GameObject> uiSpawned = null;

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
        // Draw dans l'UI
        //WorldManager.Instance.OnItemCatch += DrawInventory;
        WorldManager.Instance.OnItemCatch += DrawItem;
    }

    void GetInventoryRef()
    {
            inventoryRef = WorldManager.Instance.MyInventory;
    }

    void DrawInventory()
    {

        int _size = WorldManager.Instance.MyInventory.Pickups.Count;
        List<ItemTypes> _list = WorldManager.Instance.MyInventory.Pickups;
        for (int i = 0; i < _size; i++)
        {
            DrawItem(_list[i]);
        }
        /*int _size = WorldManager.Instance.MyInventory.Pickups.Count;
        List<ItemTypes> _list = WorldManager.Instance.MyInventory.Pickups;
        for (int i = 0; i < _size; i++) {
            //uiSpawned.Clear();
            GameObject _prefab = Resources.Load($"Prefabs/UI/{_list[i].ToString()}") as GameObject;
            //_list.Last<ItemTypes>();
            //GameObject _instance = Instantiate(_prefab);
            //_instance.transform.SetParent(FindObjectOfType<UI_Inventory>());
            //NE PAS DRAW CHAQUE ITEM À CHAQUE FOIS sinon ça draw le 1e puis le 1e et 2e
            //uiSpawned.Add(DrawItem(_prefab)); //Pas la bonne manière
            //Si je met un return ça ne va draw que le premier
            Debug.Log(_list[i]);
            //ENVOYER UNE REF A DRAW ???
        }*/
        Debug.Log("Inventory Draw !");
        //Update List
    }
    // for each items dans la liste d'inventaire : Draw une image cliquable
    // Faire un event quand je ramasse un objet pour update l'UI

    public void DrawItem(GameObject _item)
    {
        /*return*/ Instantiate(_item, this.transform);
    }
    
    public void DrawItem(ItemTypes _item)
    {
        GameObject _prefab = Resources.Load($"Prefabs/UI/{_item.ToString()}") as GameObject;
        /*return*/ Instantiate(_prefab, this.transform);
    }
}
