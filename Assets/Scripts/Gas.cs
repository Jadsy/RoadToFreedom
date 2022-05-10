using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    public AudioClip gasSound; 
    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.GetComponent<Obstacle>() != null){
            Destroy(gameObject);
            return;
        }

        if (other.gameObject.name != "Capsule"){
            return;
        }
        //make player move faster
        AudioSource.PlayClipAtPoint(gasSound,transform.position);
        player.speed = player.speed + player.acceleration;
        player.IncGas();
        Destroy(gameObject);
    }

}
