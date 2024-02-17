using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform weapon;
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(BulletPrefab, weapon.position, weapon.rotation);
        

            

    }

    private void Flip()
    {
        transform.Rotate(90f, 180f, 0f);
    }
  
    
}
