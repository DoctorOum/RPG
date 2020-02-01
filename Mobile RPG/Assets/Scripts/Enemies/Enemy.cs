using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Power = 2;
    public int Attack;
    public int Defense;

    public int enemyCurrentHealth;
    public int maxHealth;

    public DamageManager damageManager;
    PlayerScript Player;

    void Start()
    {
        enemyCurrentHealth = maxHealth;
        Player = GetComponent<PlayerScript>();
    }


    void Update()
    {
        if (enemyCurrentHealth <= 0) Destroy(gameObject);
    }
}
