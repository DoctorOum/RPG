using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public int Damage(int Power, int Attack, int Defense)
    {
        //if player attacking; Attack = player attack, Defense = enemy defense
        int damage = Power * (Attack - Defense);
        return (damage < 0 ? 0 : damage);
    }
    public int remainingHealth(int currentHealth, int damage)
    {
        int health = currentHealth - damage;
        return health;
    }
}