using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField]

    public IState CurrentState {get; private set;}

    public WalkState walkState;
    public IdleState idleState;


    public StateMachine(PlayerController player)
    {
        this.walkState = new WalkState(player);
        this.idleState = new IdleState(player);
    }

    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }

    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }

    public void Update()
    {
        if (CurrentState!=null)
        {
            CurrentState.Update();
        }
    }
}


