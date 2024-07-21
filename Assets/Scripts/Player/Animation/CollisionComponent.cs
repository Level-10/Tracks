using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D), typeof(Rigidbody2D))]

public class CollisionComponent : MonoBehaviour
{
    [SerializeField] CapsuleCollider2D capsuleCollider = null;
    [SerializeField] Rigidbody2D rb = null;
    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    void Init()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
}
