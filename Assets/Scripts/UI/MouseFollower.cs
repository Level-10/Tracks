using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] Camera mainCam;

    [SerializeField] Inventory.UI.UIInventoryItem item;

    private void Awake()
    {
        canvas = transform.root.GetComponent<Canvas>();
        mainCam = Camera.main;
        //Find item because is a child of MouseFollower
        item = GetComponentInChildren<Inventory.UI.UIInventoryItem>();
    }

    public void SetData(Sprite _sprite, int _quantity)
    {
        item.SetData(_sprite, _quantity);
    }

    private void Update()
    {
        Vector2 _position;
        // Take screen point position to transform into canvas RectTransform position
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform, Input.mousePosition, canvas.worldCamera, out _position);
        transform.position = canvas.transform.TransformPoint(_position);
    }

    public void Toggle(bool _val)
    {
        Debug.Log($"Item toggled {_val}");
        gameObject.SetActive(_val);
    }
}
