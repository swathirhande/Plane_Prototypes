using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f; 
    public float verticalInput;

    
    void Start()
    {

    }

    
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
        
    }
}


