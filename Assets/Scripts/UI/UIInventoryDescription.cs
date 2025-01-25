using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventoryDescription : MonoBehaviour
{
    [SerializeField] Image itemImage;
    [SerializeField] TMP_Text title;
    [SerializeField] TMP_Text description;

    private void Awake()
    {
        ResetDescription();
    }

    public void ResetDescription()
    {
        this.itemImage.gameObject.SetActive(false);
        this.title.text = "";
        this.description.text = "";
    }

    public void SetDescription(Sprite _sprite, string _itemName, string _itemDescription)
    {
        this.itemImage.gameObject.SetActive(true);
        this.itemImage.sprite = _sprite;
        this.title.text = _itemName;
        this.description.text = _itemDescription;
    }
}
