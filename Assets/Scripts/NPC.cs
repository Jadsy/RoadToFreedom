using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NPC{
[RequireComponent(typeof(FiniteStateMachine))]
public class NPC : MonoBehaviour
{
    FiniteStateMachine _finiteStateMachine;
    public void Awake(){
        _finiteStateMachine = this.GetComponent<FiniteStateMachine>();
    }
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
}