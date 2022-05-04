using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        spawnObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other){
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    public GameObject obstaclePrefab;
    void spawnObstacles(){
        //pick a random point to have an obstacle spawn at it;

        int obstacleIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
