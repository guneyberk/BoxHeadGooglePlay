using Unity.VisualScripting;
using UnityEngine;

public class IdleState : IState
{
    public PlayerController Player { get; }
    public IdleState(PlayerController player) 
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
    public PlayerController Player { get; }
    public WalkState(PlayerController player)
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



