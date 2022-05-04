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
        spawnCoins();
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

    public GameObject coinPrefab;
    void spawnCoins(){
        int coinsToSpawn = 10;
        for(int i = 0; i < coinsToSpawn; i++){
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider){

        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, (collider.bounds.max.x)),
            Random.Range(collider.bounds.min.y, (collider.bounds.max.y)),
            Random.Range(collider.bounds.min.z, (collider.bounds.max.z))
        );
        if(point != collider.ClosestPoint(point)){
             point = GetRandomPointInCollider(collider);
        }
        point.y = 1;
        return point;
    }
}
