using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_PlayerDestroy : MonoBehaviour
{
    public GameObject enemy;
    BoxCollider2D bodyCollider;

    void Update()
    {
        bodyCollider= GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            Destroy(other.gameObject);
            Destroy(enemy);
        }
    }
}
