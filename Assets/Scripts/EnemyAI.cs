using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    public void Move();
    public void Attack();
    public void TakeDamage();
}
public class EnemyAI : MonoBehaviour
{
    private void Start()
    {
        StandartZombie standartZombie = new StandartZombie();
        FastZombie fastZombie = new FastZombie();
        TankZombie tankZombie = new TankZombie();
        BossZombie bossZombie = new BossZombie();
    }
}

public class StandartZombie : EnemyAI, IEnemy
{
    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }
}
public class FastZombie : EnemyAI, IEnemy
{
    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }
}
public class TankZombie : EnemyAI, IEnemy
{
    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }
}
public class BossZombie : EnemyAI, IEnemy
{
    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }
}
