using UnityEngine;
using UnityEngine.UI;

public class UI_Items : MonoBehaviour
{
    [SerializeField] Button button = null;

    void Start()
    {
        Init();
    }

    void Update()
    {
        // Idk if a better solution exist
        if (Input.GetMouseButtonDown(1)) {
            DropItem();
            return;
        }
    }

    void Init()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(UseItem);
        //button.clickable
    }

    void UseItem()
    {
        Debug.Log("Item Used !");
    }

    void DropItem()
    {
        //WorldManager.Instance.MyInventory.RemoveItemFromInventory();
        Destroy(gameObject);
        WorldManager.Instance.OnItemDrop?.Invoke(gameObject);
        Debug.Log("Item Dropped !");
    }
}
