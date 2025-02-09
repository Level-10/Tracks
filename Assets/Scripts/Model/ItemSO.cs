using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu]
    public class ItemSO : ScriptableObject
    {
        //Data describing the item
        [field: SerializeField] // "field:" is necessary because it's a property
        public bool IsStackable { get; set; } //That type of values is a Property of the Item

        public int ID => GetInstanceID(); //This method is only in ScriptableObject & returns a unique ID of this instance

        [field: SerializeField]
        public int MaxStackSize { get; set; } = 1;

        [field: SerializeField]
        public string Name { get; set; }

        [field: SerializeField]
        [field: TextArea] //Create a textarea in the inspector or level
        public string Description { get; set; }

        [field: SerializeField]
        public Sprite ItemImage { get; set; }

    }
}