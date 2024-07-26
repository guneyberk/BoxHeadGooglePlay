using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Enemies",menuName ="Enemies")]
public class EnemiesScriptableObj : ScriptableObject 
{
    [SerializeField] string _name;
    [SerializeField] float _healthPoints; 
    public float HealthPoints => _healthPoints;

    [SerializeField] float _speed;


    [SerializeField] float _damagePoints;
    public float DamagePoints => _damagePoints;


}
