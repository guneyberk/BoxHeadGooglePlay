using UnityEngine;


public abstract class EnemyFactory : MonoBehaviour
{
    public abstract IEnemy CreateEnemy(Vector3 position);
}

public class StandartZombieFactory : EnemyFactory
{
    [SerializeField] private StandartZombie standartZombiePrefab;
    public override IEnemy CreateEnemy(Vector3 position)
    {
        GameObject instance = Instantiate(standartZombiePrefab.gameObject, position, Quaternion.identity);

        StandartZombie newStandartZombie = instance.GetComponent<StandartZombie>();

        newStandartZombie.Initialize();
        return newStandartZombie;
    }
}

