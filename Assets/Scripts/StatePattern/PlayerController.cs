using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ICharacterState idleState;
    public ICharacterState walkState;


    ICharacterState _currentState;
    private float walkPower = 10f;

    private void Start()
    {
        idleState = new IdleState(this);
        walkState = new WalkState(this);

        _currentState = idleState;
        _currentState.EnterState();
    }


    private void Update()
    {
        _currentState.UpdateState();
    }

    public void TransitionState(ICharacterState newState)
    {
        _currentState.ExitState();
        _currentState = newState;
        _currentState.EnterState();
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime * walkPower);
    }
}
