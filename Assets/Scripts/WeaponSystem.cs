using UnityEngine;
public interface IWeapons
{
    public void Fire();

    public void Reload();
}



public class WeaponSystem : MonoBehaviour
{
    private void Start()
    {
        IWeapons pistol = new Pistol();
        IWeapons uzi = new Uzi();
        IWeapons shotgun = new Shotgun();
        IWeapons grenades = new Grenades();
        IWeapons knife = new Knife();

    }
}

class Pistol : WeaponSystem, IWeapons
{
    public void Fire()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }
}
class Uzi : WeaponSystem, IWeapons
{
    public void Fire()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }
}
class Shotgun : WeaponSystem, IWeapons
{
    public void Fire()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }
}

class Grenades : WeaponSystem, IWeapons
{
    public void Fire()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }
}

class Knife : WeaponSystem, IWeapons
{
    public void Fire()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }
}



