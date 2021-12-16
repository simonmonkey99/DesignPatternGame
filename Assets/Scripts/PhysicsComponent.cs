using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsComponent : MonoBehaviour
{
    private bool ObjectFound;
    private Rigidbody2D rb;
    public float playerSpeed=10;
    public Action<Item> OnItemTouch;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 direction) {rb.AddForce(direction*playerSpeed,ForceMode2D.Impulse);}

    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.TryGetComponent(out Item item))
        {
            OnItemTouch?.Invoke(item);
        }

        
    }
    
}
