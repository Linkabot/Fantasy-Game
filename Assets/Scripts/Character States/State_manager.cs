using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_manager : MonoBehaviour

{
    public State currentState;

    public void Set(State state)
    {
        currentState = state;
    }
}
