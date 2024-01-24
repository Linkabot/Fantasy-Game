using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    public abstract void EnterState(State_manager character);

    public abstract void UpdateState(State_manager character);
}
