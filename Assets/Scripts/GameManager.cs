using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyFactory standartZombieFactory;
    void Start()
    {
        IEnemy stdZombie = standartZombieFactory.CreateEnemy(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
