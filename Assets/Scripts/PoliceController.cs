using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliceController : MonoBehaviour
{

    public Transform playerObject;
    NavMeshAgent policeMesh; 
    // Start is called before the first frame update
    void Start()
    {
        policeMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        policeMesh.SetDestination(playerObject.position); 
    }

}
