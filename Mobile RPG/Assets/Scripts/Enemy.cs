using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Power = 2;
    public int Attack;
    public int Defense;

    public int enemyCurrentHealth;
    public int maxHealth;

    public DamageManager damageManager;
    PlayerScript Player;
    //HealthManager Health;
    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = maxHealth;

        //damageManager = GetComponent<DamageManager>();
        Player = GetComponent<PlayerScript>();
        //Health = GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCurrentHealth <= 0) Destroy(gameObject);
    }
}
