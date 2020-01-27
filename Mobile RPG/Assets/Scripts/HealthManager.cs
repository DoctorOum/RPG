using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int remainingHealth(int currentHealth, int damage)
    {
        int health = currentHealth - damage;
        return health;
    }
}
