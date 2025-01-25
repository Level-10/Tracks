using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryController : MonoBehaviour
{
    // Ref to inventoryPage
    [SerializeField] UIInventoryPage inventoryUI;

    public int inventorySize = 1;

    void Start()
    {
        inventoryUI.InitializeInventoryUI(inventorySize);
    }

    public void OpenInventory(InputAction.CallbackContext _callback)
    {
        if (inventoryUI.isActiveAndEnabled == false)
        {
            inventoryUI.Show();
        }
        else
        {
            inventoryUI.Hide();
        }
    }
}
