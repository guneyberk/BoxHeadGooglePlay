using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(PlayerInput),typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] Weapon _weapons;
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] PlayerInput _playerInput;
    [SerializeField] PlayerAudio _playerAudio;
}
public class PlayerAudio : MonoBehaviour
{

}

public class PlayerInput : MonoBehaviour
{

}

public class PlayerMovement: MonoBehaviour
{

}
