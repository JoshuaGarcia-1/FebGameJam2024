using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_script : MonoBehaviour
{
    public Transform enemy;
    public GameObject drop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Get the GameObject that collided with the bullet
        GameObject alien = collision.gameObject;

        // Check if the collided object is the one you want to disappear
        // Replace "TargetObjectName" with the name of the GameObject you want to disappear
        if (alien.tag == "enemy")
        {
            // Destroy the collided object
            
            Debug.Log("hit");
            Instantiate(drop, enemy.position, enemy.rotation);
        }

        // Destroy the bullet regardless of the object it collided with
        
        
    }
}
