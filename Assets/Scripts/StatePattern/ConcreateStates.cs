using UnityEngine;

public class IdleState : IState
{
    private PlayerController _controller;

    public IdleState(PlayerController controller)
    {
        this._controller = controller;
    }

    public void Enter()
    {
        Debug.Log("Entering Idle State");
    }

    public void Update()
    {
        if (_controller.IsMoving())
        {
            _controller.SetState(new WalkState(_controller));
        }
    }

    public void Exit()
    {
        Debug.Log("Exiting Idle State");
    }
}


class WalkState : IState
{
    PlayerController _controller;

    public WalkState(PlayerController controller)
    { this._controller = controller; }

    public void Enter()
    {
        Debug.Log("Entering Walk State");
    }

    public void Update()
    {
        if (!_controller.IsMoving())
        {
            _controller.SetState(new IdleState(_controller));
        }


    }

    public void Exit()
    {
        Debug.Log("Exiting the Moving state");
    }


}

