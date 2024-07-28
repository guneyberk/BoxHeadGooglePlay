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

public class Standartombie : MonoBehaviour, IProduct
{
    [SerializeField] private string productName = "ProductA";
    public string ProductName { get => productName; set => productName = value;}

    public void Initialize()
    {
        gameObject.name = productName;
    }
}

public class ConcreateFactoryA: Factory
{
    [SerializeField] private ProductA productPrefab;

    public override IProduct GetProduct(Vector3 position)
    {
        GameObject instance = Instantiate(productPrefab.gameObject,position,Quaternion.identity);
        ProductA newProduct = instance.GetComponent<ProductA>();

        newProduct.Initialize();
        return newProduct;
    }
}