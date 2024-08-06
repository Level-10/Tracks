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
        FindFurnitures();
    }

    void Init()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    RaycastHit2D FindAroundPlayer()
    {
        return Physics2D.CircleCast(transform.position, 2, Vector2.right);
    }

    void FindFurnitures()
    {
        RaycastHit2D _result = FindAroundPlayer();
        if (_result.rigidbody.gameObject.CompareTag(Tags.FURNITURE))
        {
            Debug.Log("Furniture at hand range");
        }
        //Find type of furniture for draw interact UI or to use the right object 
        //if (_result.rigidbody.gameObject.GetComponent<Items>().GetType() == typeof(Items)) 
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 2);
        Gizmos.color = Color.white;
    }
}
