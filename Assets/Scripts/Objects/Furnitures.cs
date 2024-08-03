using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum FurnitureTypes
{
    Box,
    None
}

public class Furnitures : MonoBehaviour
{
    [SerializeField] FurnitureTypes type = FurnitureTypes.None;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
