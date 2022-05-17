using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.FSM.States{

    [CreateAssetMenu(fileName = "FarState", menuName="RoadToFreedom/States/Far", order=1)]
    public class FarState : AbstractFSMState
    {

        public override void OnEnable(){
            base.OnEnable();
            StateType = FSMStateType.FAR;
        }

        public override bool EnterState(){
            EnteredState = base.EnterState();
            if(EnteredState){

            Debug.Log("Entered Far State");

                //_fsm.policeCar.transform.localPosition = new Vector3(0,0,-8f);
            }


            return EnteredState;
        }

        public override void UpdateState(){
            Debug.Log("Updating Far state");
            if(EnteredState){
                
            }
        }

        public override bool ExitState(){
            base.ExitState();
            Debug.Log("Exited Far State");

            return true;
        }
    }
}
