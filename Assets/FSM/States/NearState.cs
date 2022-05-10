using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.FSM.States{
    [CreateAssetMenu(fileName = "NearState", menuName="RoadToFreedom/States/Near", order=2)]
public class NearState : AbstractFSMState
{

 public override bool EnterState(){
            base.EnterState();
            Debug.Log("Entered Near State");

            return true;
        }

        public override void UpdateState(){
            Debug.Log("Updating Near state");
        }

        public override bool ExitState(){
            base.ExitState();
            Debug.Log("Exited Near State");

            return true;
        }
}
}