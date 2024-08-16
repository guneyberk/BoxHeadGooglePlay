using UnityEngine;

[RequireComponent(typeof(PlayerAudio), typeof(Player))]
public class Player : MonoBehaviour
{
    [SerializeField] WeaponScriptableObj _weapons;
    Player _playerInput;
    PlayerAudio _playerAudio;

    private void Start()
    {
        Player playerInput = new Player();
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

