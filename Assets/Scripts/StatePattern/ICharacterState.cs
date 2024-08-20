using UnityEngine;

public interface ICharacterState
{
    void EnterState();
    void UpdateState();
    void ExitState();
}

public class IdleState : ICharacterState
{
    PlayerController _player;
    public IdleState(PlayerController player)
    {
        _player = player;
    }


    public void EnterState()
    {
        Debug.Log("Entering Idle State");
        //_player anim set idle

    }

    public void ExitState()
    {
        Debug.Log("Exiting the Idle State");
    }

    public void UpdateState()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _player.TransitionState(_player.walkState);
        }
    }
}

public class WalkState : ICharacterState
{
    PlayerController _player;
    private Vector3 direction;

    public WalkState(PlayerController player)
    {
        _player = player;
    }
    public void EnterState()
    {
        Debug.Log("Entering Walking State");
        //_player Anim Set Walk
    }

    public void ExitState()
    {
        Debug.Log("Exiting the WalkState");
    }

    public void UpdateState()
    {
        //if(!Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.D))
        //{
        //    _player.TransitionState(_player.idleState);
        //}

        switch (Input.inputString.ToUpper())
        {
            case "W":
                direction = Vector3.forward;
                _player.Move(direction);
                break;
            case "A":
                direction = Vector3.left;
                _player.Move(direction);
                break;
            case "S":
                direction = Vector3.back;
                _player.Move(direction);
                break;
            case "D":
                direction = Vector3.right;
                _player.Move(direction);
                break;
            default:
                _player.TransitionState(_player.idleState);
                break;
        }
    }
}

