using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound; 
    public float turnSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.GetComponent<Obstacle>() != null){
            Destroy(gameObject);
            return;
        }


        if(other.gameObject.name != "Capsule"){
            return;
        }



        AudioSource.PlayClipAtPoint(coinSound,transform.position);
        GameManager.inst.IncrementScore();
        Destroy(gameObject);
    }
}
