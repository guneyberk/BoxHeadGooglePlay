using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] Weapon _weapons;
    PlayerMovement _playerMovement;
    PlayerInput _playerInput;
    PlayerAudio _playerAudio;

    private void Start()
    {
        PlayerMovement playerMovement = new PlayerMovement();
        PlayerInput playerInput = new PlayerInput();
        PlayerAudio playerAudio = new PlayerAudio();
    }
}
public class PlayerAudio : MonoBehaviour
{

}

public class PlayerInput : MonoBehaviour
{

}

public class PlayerMovement : MonoBehaviour
{

}
