using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory.UI
{
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
            itemImage.gameObject.SetActive(false);
            title.text = "";
            description.text = "";
        }

        public void SetDescription(Sprite _sprite, string _itemName, string _itemDescription)
        {
            itemImage.gameObject.SetActive(true);
            itemImage.sprite = _sprite;
            title.text = _itemName;
            description.text = _itemDescription;
        }
    }
}