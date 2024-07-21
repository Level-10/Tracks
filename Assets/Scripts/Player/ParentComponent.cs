using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParentComponent : MonoBehaviour
{
    [SerializeField] protected Player playerRef = null;
    protected virtual void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    void Init()
    {
        playerRef = GetComponent<Player>();
    }
}
