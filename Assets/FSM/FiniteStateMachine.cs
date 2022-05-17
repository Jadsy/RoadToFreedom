using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    [SerializeField]
    AbstractFSMState _startingState;
    AbstractFSMState _previousState;
    
    AbstractFSMState _currentState;


    [SerializeField]
    List<AbstractFSMState> _validStates;
    Dictionary<FSMStateType, AbstractFSMState> _fsmStates;
    public GameObject policeCar;
    public void Awake(){
        _currentState = null;


        _fsmStates = new Dictionary<FSMStateType, AbstractFSMState>();

        foreach(AbstractFSMState state in _validStates){
            state.SetExecutingFSM(this);
            _fsmStates.Add(state.StateType, state);
        }
    }

    public void Start(){
        if(_startingState != null)
        {
        EnterState(_startingState);
        }
    }
    

    public void Update(){
        if(_currentState != null){
            _currentState.UpdateState();
        }
    }

    public void EnterState(AbstractFSMState nextState){
        if(nextState == null){
            return;
        }
        if(_currentState != null){
            _currentState.ExitState();
        }
        _currentState = nextState;
        _currentState.EnterState();
    }


    public void EnterState(FSMStateType type){
        if(_fsmStates.ContainsKey(type)){
            AbstractFSMState nextState = _fsmStates[type];
            EnterState(nextState);
        }
    }

}
