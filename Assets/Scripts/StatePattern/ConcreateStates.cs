using Unity.VisualScripting;
using UnityEngine;

public class IdleState : IState
{
    public InputHandler Player { get; }
    public IdleState(InputHandler player) 
    {
        Player = player;
    }


    public void Enter()
    {
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}

public class WalkState : IState
{
    public InputHandler Player { get; }
    public WalkState(InputHandler player)
    {
        Player = player;
    }


    public void Enter()
    {
        Debug.Log("Entering the walk state");

        //Animations
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
       if(Player != null) { }
    }

   
}



