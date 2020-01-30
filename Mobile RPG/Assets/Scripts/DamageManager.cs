using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public int Damage(float Power, int Attack, int Defense)
    {
        //if player attacking; Attack = player attack, Defense = enemy defense
        int damage = (int)(Power * (Attack / Defense));
        return (damage < 0 ? 0 : damage); //returns zero if damage is negative
    }
    public int remainingHealth(int currentHealth, int damage)
    {
        int health = currentHealth - damage;
        return health;
    }
}