using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;
    //public GameObject zomb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    // Update is called once per frame
    void Update()
    {

    }


    // Function called when the bullet collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get the GameObject that collided with the bullet
        GameObject zomb = collision.gameObject;

        // Check if the collided object is the one you want to disappear
        // Replace "TargetObjectName" with the name of the GameObject you want to disappear
        if (zomb.tag == "zombie")
        {
            // Destroy the collided object
            Destroy(zomb);
            Debug.Log("hit");
            Destroy(gameObject);
        }

        // Destroy the bullet regardless of the object it collided with
        
        
    }
}