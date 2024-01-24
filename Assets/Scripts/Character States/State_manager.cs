using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_manager : MonoBehaviour

{
    State currentState;
    Inactive_idle inactiveIdle = new Inactive_idle();
    Active_combat activeCombat = new Active_combat();
    // Start is called before the first frame update
    void Start()
    {
        currentState = inactiveIdle;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
