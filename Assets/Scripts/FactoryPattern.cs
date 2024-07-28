using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProduct
{
    public string ProductName { get; set; }
    public void Initialize();
}

public abstract class Factory : MonoBehaviour
{
    public abstract IProduct GetProduct(Vector3 position);
}



public class ConcreateFactoryA: Factory
{
    [SerializeField] private StandartZombie productPrefab;

    public override IProduct GetProduct(Vector3 position)
    {
        GameObject instance = Instantiate(productPrefab.gameObject,position,Quaternion.identity);
        StandartZombie newProduct = instance.GetComponent<StandartZombie>();

        newProduct.Initialize();
        return newProduct;
    }
}