using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;
    public void SpawnTile(bool spawning)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if(spawning){
            temp.GetComponent<GroundTile>().spawnObstacles();
            temp.GetComponent<GroundTile>().spawnCoins();
            temp.GetComponent<GroundTile>().spawnGas();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++){
            if (i < 2){
                SpawnTile(false);
            }else{
                SpawnTile(true);
            }
        }
    }
}

