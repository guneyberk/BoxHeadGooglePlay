using UnityEngine;

public interface IEnemy
{
    public string ProductName { get; set; }

    public void Initialize();
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

public class StandartZombie : MonoBehaviour,IEnemy
{
    [SerializeField] string productName = "StandartZombie";
    public string ProductName { get => productName; set => productName = value; }

    public void Initialize()
    {
        gameObject.name = productName;
    }
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
    public string ProductName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Initialize()
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
    public string ProductName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Initialize()
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
    public string ProductName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Initialize()
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
