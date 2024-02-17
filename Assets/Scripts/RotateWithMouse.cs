using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Get the GameObject position in screen space
        Vector3 objectPosition = Camera.main.WorldToScreenPoint(transform.position);

        // Calculate the direction vector from the object to the mouse
        Vector3 direction = mousePosition - objectPosition;

        // Calculate the angle from the direction vector
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the GameObject around the Z-axis
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
}
