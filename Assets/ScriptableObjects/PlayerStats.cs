using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="PlayerStats", menuName = "PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField] string playerName;
    [SerializeField] int playerHealth;
    [SerializeField] float movementSpeed;
    
}
