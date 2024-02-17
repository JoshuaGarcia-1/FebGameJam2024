using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        transform.Translate(move * speed * Time.deltaTime);
    }
}
