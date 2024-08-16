using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private PlayerControllerState _player;

    public IdleState(PlayerControllerState player)
    {
        _player = player;
    }

    public void Enter()
    {
        //Code runs when first enter state
    }
    public void Update()
    {
        //Add logic
        //transition to another state
    }
    public void Exit() 
    {
        //code runs when Exit()
    }
}
