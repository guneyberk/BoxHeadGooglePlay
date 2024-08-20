using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="WeaponStats", menuName ="WeaponStats")]
public class WeaponStats : ScriptableObject
{
    [SerializeField] string weaponName;
    [SerializeField] int weaponDamage;
    [SerializeField] float weaponFireRate;
    [SerializeField] float weaponReloadSpeed;
}
