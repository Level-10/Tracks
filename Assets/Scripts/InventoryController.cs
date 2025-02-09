using UnityEngine;
using UnityEngine.InputSystem;

namespace Inventory
{
    public class InventoryController : MonoBehaviour
    {
        // Ref to inventoryPage
        [SerializeField] UI.UIInventoryPage inventoryUI;

        [SerializeField] Model.InventorySO inventoryData;

        void Start()
        {
            PrepareUI();
            //inventoryData.Initialize();
        }

        private void PrepareUI()
        {
            inventoryUI.InitializeInventoryUI(inventoryData.Size);
            //Events subscribes
            inventoryUI.OnDescriptionRequested += HandleDescriptionRequest;
            inventoryUI.OnSwapItems += HandleSwapItems;
            inventoryUI.OnStartDragging += HandleDragging;
            inventoryUI.OnItemActionRequested += HandleItemActionRequest;
        }

        private void HandleDescriptionRequest(int _itemIndex)
        {
            Model.InventoryItem _inventoryItem = inventoryData.GetItemAt(_itemIndex);
            if (_inventoryItem.IsEmpty)
            {
                inventoryUI.ResetSelection();
                return;
            }
            Model.ItemSO _item = _inventoryItem.item;
            inventoryUI.UpdateDescription(_itemIndex, _item.ItemImage, _item.Name, _item.Description);
        }

        private void HandleSwapItems(int _itemIndex_1, int _itemIndex_2)
        {
        }

        private void HandleDragging(int _itemIndex)
        {
        }

        private void HandleItemActionRequest(int _itemIndex)
        {

        }

        public void OpenInventory(InputAction.CallbackContext _callback)
        {
            if (inventoryUI.isActiveAndEnabled == false)
            {
                inventoryUI.Show();
                foreach (var _item in inventoryData.GetCurrentInventoryState()) // Retrun dictionary, each item will be a key value pair
                {
                    inventoryUI.UpdateData(_item.Key, // index of item to update
                        _item.Value.item.ItemImage,
                        _item.Value.quantity);
                }
            }
            else
            {
                inventoryUI.Hide();
            }
        }
    }
}