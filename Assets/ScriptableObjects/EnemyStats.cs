using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="EnemyStats", menuName ="EnemyStats")]
public class EnemyStats :ScriptableObject
{
    [SerializeField] string enemyName;
    [SerializeField] int enemyHealthPoint;
    [SerializeField] int enemyDamagePoint;
    [SerializeField] float enemySpeed;
}

