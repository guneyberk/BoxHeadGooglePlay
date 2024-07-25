using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] Weapon _weapons;
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] PlayerInput _playerInput;
    [SerializeField] PlayerAudio _playerAudio;

    private void Start()
    {
        _playerAudio = GetComponent<PlayerAudio>();
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
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
