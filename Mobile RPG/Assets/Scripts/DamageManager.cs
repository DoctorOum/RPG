using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public float Damage(float Power, float Attack, float Defense)
    {
        //if player attacking; Attack = player attack, Defense = enemy defense
        float damage = Power * (Attack / Defense);
        return (damage < 0 ? 0 : damage); //returns zero if damage is negative
    }
    public int remainingHealth(int currentHealth, int damage)
    {
        int health = currentHealth - damage;
        return health;
    }
}