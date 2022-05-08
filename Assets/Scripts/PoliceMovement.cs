using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{
  
    public float acceleration = 0.05f;
    public float speed = 5f;

    public Rigidbody rb;

    float horizontalInput;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        
        rb.MovePosition(rb.position + forwardMove);
    }

    



    
}
