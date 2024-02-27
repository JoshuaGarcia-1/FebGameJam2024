using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
//    public float rightBorder;
//    public float topBorder;
    public float speed;
    public Transform other;
//    Vector2 destination;
//    public LayerMask wall;
    void Start()
    {
//       SetDestination();
    }
/*    void SetDestination()
    {
        destination.x = Random.Range(-rightBorder, rightBorder);
        destination.y = Random.Range(-topBorder, topBorder);
    }
    */
    // Update is called once per frame
    void Update()
    {
    //    if (Vector2.Distance(destination, transform.position) > 0.1f)
    //    {
        
        transform.position = Vector2.MoveTowards(transform.position, other.position, speed * Time.deltaTime);
        
    //   }
    //    else SetDestination();
       
    }
/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hit Something!!");
        if(gameObject.GetComponent<Collider2D>().IsTouchingLayers(wall))
        {
         //   Debug.Log("Hit a Wall!!");
            SetDestination();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("Hit Something!!");
        if (gameObject.GetComponent<Collider2D>().IsTouchingLayers(wall))
        {
           // Debug.Log("Hit a Wall!!");
            SetDestination();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       // Debug.Log("Hit Something!!");
        if (gameObject.GetComponent<Collider2D>().IsTouchingLayers(wall))
        {
          //  Debug.Log("Hit a Wall!!");
            SetDestination();
        }
    }
    */
}
