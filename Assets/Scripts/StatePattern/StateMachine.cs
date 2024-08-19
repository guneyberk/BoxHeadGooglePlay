using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StateMachine 
{
   public IState CurrentState {  get; private set; }

    public IdleState idleState;
    public WalkState walkState;

    public void Initialize(IState state)
    {
        CurrentState = state;
        state.Enter();
    }

    public void TransitionTo(IState nextState) 
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }

    public void Update ()
    {
        if(CurrentState != null)
        {
            CurrentState.Update();
        }
    }

    public StateMachine(InputHandler player) 
    {
        this.walkState = new WalkState(player);
        this.idleState = new IdleState(player);
    }
}
