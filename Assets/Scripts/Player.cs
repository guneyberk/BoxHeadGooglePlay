using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(Player))]
public class Player : MonoBehaviour
{
    //[SerializeField] WeaponScriptableObj _weapons;


    private void Start()
    {
        InputHandler _playerController = new InputHandler();
    }

    public void Update()
    {
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
public class PlayerAudio { }


