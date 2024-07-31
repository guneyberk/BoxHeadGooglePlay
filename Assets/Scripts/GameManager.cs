using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] EnemyFactory standartZombieFactory;
    void Start()
    {
        IEnemy stdZombie = standartZombieFactory.CreateEnemy(new Vector3(0, 0, 0));
        stdZombie.Attack();
    }

  
    void Update()
    {
        
    }
}
