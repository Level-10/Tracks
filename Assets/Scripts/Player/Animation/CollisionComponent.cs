using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D), typeof(Rigidbody2D))]

public class CollisionComponent : MonoBehaviour
{
    [SerializeField] CapsuleCollider2D capsuleCollider = null;
    [SerializeField] Rigidbody2D rb = null;
    [SerializeField] LayerMask furnitureMask = 3;
    [SerializeField] float detectionRange = 1;

    void Start()
    {
        Init();
        InvokeRepeating(nameof(FindFurnitures), 1, .2f);
    }

    void Update()
    {
        
    }

    void Init()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    bool FindAroundPlayer()
    {
        return Physics2D.CircleCast(transform.position, detectionRange, Vector2.right, 0, furnitureMask);
    }

    void FindFurnitures()
    {
        bool _result = FindAroundPlayer();
        if (!_result) return;
            Debug.Log("Furniture at hand range");
        //Find type of furniture for draw interact UI or to use the right object 
        //if (_result.rigidbody.gameObject.GetComponent<Items>().GetType() == typeof(Items)) 
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
        Gizmos.color = Color.white;
    }
}
