using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pickups : MonoBehaviour
{
    [SerializeField] Collider2D boxCollider = null;
    void Start()
    {
        boxCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Enter !");
        if (collision.CompareTag("Player"))
        {
            //Player _player = _collision.transform.GetComponent<Player>();
            Destroy(gameObject);
        }
    }
}
