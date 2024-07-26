using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IWeapons
{
    public void Fire();

    public void Reload();
}



public class WeaponSystem : MonoBehaviour, IWeapons
{
    private void Start()
    {
        IWeapons pistol = new Pistol();
        IWeapons uzi = new Uzi();
        IWeapons shotgun = new Shotgun();
        IWeapons grenades = new Grenades();
        IWeapons knife = new Knife();
        
    }
    public void Fire();
    public void Reload();




}

class Pistol: WeaponSystem
{

}
class Uzi : WeaponSystem 
{
    
}
class Shotgun : WeaponSystem
{

}

class Grenades : WeaponSystem
{

}

class Knife : WeaponSystem
{

}



