using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.FSM.States{
    [CreateAssetMenu(fileName = "NearState", menuName="RoadToFreedom/States/Near", order=2)]
public class NearState : AbstractFSMState
{

    [SerializeField]
    float _noContactDuration = 7f;

    float _totalDuration;

    public override void OnEnable(){
            base.OnEnable();
            StateType = FSMStateType.NEAR;
        }

    public override bool EnterState(){
            EnteredState = base.EnterState();
            if(EnteredState){
                Debug.Log("Entered Near State");
                _totalDuration = 0f;
                //_fsm.policeCar.transform.localPosition = new Vector3(0,0,-6f);
            }



            return EnteredState;
        }

        public override void UpdateState(){
            if(EnteredState){
                _totalDuration += Time.deltaTime;
                Debug.Log("Updating Near state: " + _totalDuration);
                
                if(_totalDuration >= _noContactDuration){
                    _fsm.EnterState(FSMStateType.FAR);
                }
            }
        }

        public override bool ExitState(){
            base.ExitState();
            Debug.Log("Exited Near State");

            return true;
        }
}
}