using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : State_manager
{
    public Life life;
    public State active;
    public State inactive;
    

    // Start is called before the first frame update
    void Start()
    {
        Set(inactive);
    }

    public void setNextState()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
