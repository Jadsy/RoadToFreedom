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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other){
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
    public GameObject obstaclePrefab4;
    public void spawnObstacles(){
        //pick a random point to have an obstacle spawn at it;

        int obstacleIndex = Random.Range(2,5);
        int obst = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleIndex).transform;
        if(obst == 2){
            Instantiate(obstaclePrefab2, spawnPoint.position, Quaternion.identity, transform);
            return;
        } else if(obst == 3){
            Instantiate(obstaclePrefab3, spawnPoint.position, Quaternion.identity, transform);
            return;
        } else if(obst ==4){
            Instantiate(obstaclePrefab4, spawnPoint.position, Quaternion.identity, transform);
            return;
        }
    }

    public GameObject coinPrefab;
    public void spawnCoins(){
        int coinsToSpawn = 10;
        for(int i = 0; i < coinsToSpawn; i++){
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    public GameObject gasPrefab;
    public void spawnGas(){
        int gasToSpawn = 2;
        for(int i=0; i < gasToSpawn; i++){
        GameObject temp = Instantiate(gasPrefab, transform);
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
