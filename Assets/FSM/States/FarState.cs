using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.FSM.States{

    [CreateAssetMenu(fileName = "FarState", menuName="RoadToFreedom/States/Far", order=1)]
    public class FarState : AbstractFSMState
    {
        public override bool EnterState(){
            base.EnterState();
            Debug.Log("Entered Far State");

            return true;
        }

        public override void UpdateState(){
            Debug.Log("Updating Far state");
        }

        public override bool ExitState(){
            base.ExitState();
            Debug.Log("Exited Far State");

            return true;
        }
    }
}
