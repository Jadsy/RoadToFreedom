using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision other) {
        //want to end game when hit obstacle
        if (other.gameObject.name == "Capsule"){
            playerMovement.End();
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
