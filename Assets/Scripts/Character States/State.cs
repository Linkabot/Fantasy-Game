using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected Character core;
    public float startTime;
    public bool complete;
    public bool complettionTime;

    private void Awake()
    {
        core = transform.root.GetComponent<Character>();
    }

    public virtual void Enter()
    {

    }

    public virtual void Execute()
    {

    }
}
