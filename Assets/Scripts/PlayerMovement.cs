using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float boost = 2.0f;
    public float acceleration = 0.05f;
    bool alive = true;
    public float speed = 5f;
    public float horizontalMultiplier = 1.3f;
    public Rigidbody rb;

    float horizontalInput;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if(!alive){
            return;
        }
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = horizontalMultiplier * transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    public void End(){
        alive = false;
        Invoke("restart",2);
    }

    void restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 booster = new Vector3(0,0,5);
        if (Input.GetKeyDown("space"))
        {
            rb.MovePosition(rb.position + booster );
        }
        if (transform.position.y < -10){
            End();
        }
    }
}
