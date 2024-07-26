using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Weapon", menuName ="Weapon")]
public class WeaponScriptableObj : ScriptableObject
{
    public string _name;
    [SerializeField]
    float _damage;
    public float BaseDamage => _damage;
    [SerializeField, Min(0)]
    float _fireRate;
    public float FireRate => _fireRate;
    [SerializeField]
    float _reloadTime;
    public float ReloadTime => _reloadTime;
}
