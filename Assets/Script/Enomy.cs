using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enomy : MonoBehaviour
{
    public int Damage;
    public float Speed;
    void Update()
    {
        transform.Translate(Vector2.left*Speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Player"))
        {
            colision.GetComponent<Player>().ApplyDamage(Damage);
            Destroy(gameObject);
        }
    }
}
