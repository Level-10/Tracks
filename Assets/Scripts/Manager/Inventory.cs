using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypes
{
    smallKey,
    greyKey,
    goldKey,
    wrench
}

public class Inventory : MonoBehaviour
{
    [SerializeField] int smallKeysCount = 0;
    [SerializeField] int greyKeysCount = 0;
    [SerializeField] int goldKeysCount = 0;
    [SerializeField] int WrenchesCount = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddKey(ItemTypes _index)
    {
        if (_index == ItemTypes.smallKey) smallKeysCount++;
        else if (_index == ItemTypes.greyKey) greyKeysCount++;
        else if (_index == ItemTypes.goldKey) goldKeysCount++;
        else if (_index == ItemTypes.wrench) WrenchesCount++;
    }
}
