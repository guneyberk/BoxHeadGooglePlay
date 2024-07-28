using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] WeaponScriptableObj _weapons;
    PlayerMovement _playerMovement;
    PlayerInput _playerInput;
    PlayerAudio _playerAudio;

    private void Start()
    {
        PlayerMovement          playerMovement = new PlayerMovement();
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

}

public class PlayerMovement : Player
{

}
