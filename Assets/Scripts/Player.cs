using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(Player))]
public class Player : MonoBehaviour
{
    //[SerializeField] WeaponScriptableObj _weapons;
    PlayerAudio _playerAudio;

    private void Start()
    {
        PlayerAudio playerAudio = new PlayerAudio();
    }


    public void TakeDamage()
    {

    }

    public void Shoot()
    {
        Debug.Log("Player Shoot");
    }

    public void Move(Vector3 direction)
    {
        transform.position += direction;
        Debug.Log("Player moved to" + transform.position);
    }

}
public class PlayerAudio : Player
{

}

public class PlayerController : MonoBehaviour
{
    IState _currentState;

    private void Start()
    {
        SetState(new IdleState(this));
    }

    private void Update()
    {
        _currentState?.Update();
    }

    public void SetState(IState newState)
    {
        _currentState?.Exit();

        _currentState = newState;

        _currentState?.Enter();
    }


    public bool IsMoving()
    {
        return Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;
    }
}
