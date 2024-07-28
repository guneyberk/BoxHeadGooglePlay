using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyFactory : MonoBehaviour
{
    public abstract IEnemy CreateEnemy(Vector3 position);
}

public class StandartZombieFactory : EnemyFactory
{
    public GameObject standartZombiePrefab;
    public override IEnemy CreateEnemy(Vector3 position)
    {
        GameObject stdZombie = Instantiate(standartZombiePrefab,position,Quaternion.identity);
        return stdZombie.GetComponent<IEnemy>();
    }

    
}