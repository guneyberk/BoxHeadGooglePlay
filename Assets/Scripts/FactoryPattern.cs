using UnityEngine;

public interface IProduct
{
    public string ProductName { get; set; }

    public void Initialize();
}
public abstract class Factory:MonoBehaviour
{
    public abstract IProduct GetProduct(Vector3 position);
}




public class StandartZombieFactory : Factory
{
    [SerializeField] private StandartZombie standartZombiePrefab;
    public override IProduct GetProduct(Vector3 position)
    {
        GameObject instance = Instantiate(standartZombiePrefab.gameObject, position,Quaternion.identity);

        StandartZombie newStandartZombie = instance.GetComponent<StandartZombie>();

        newStandartZombie.Initialize();
        return newStandartZombie;
    }
}

