using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    [SerializeField] WeaponScriptableObj _weapons;
    PlayerInput _playerInput;
    PlayerAudio _playerAudio;

    private void Start()
    {
        PlayerInput playerInput = new PlayerInput();
        PlayerAudio playerAudio = new PlayerAudio();



    }


    public void TakeDamage()
    {

    }


}
public class PlayerAudio : Player
{

}

public class PlayerInput : Player
{
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

