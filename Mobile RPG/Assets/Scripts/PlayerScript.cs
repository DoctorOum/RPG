using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour
{

    public int Power = 2;
    public int Attack;
    public int Defense;

    public int playerCurrentHealth;
    public int maxHealth;

    DamageManager damageManager;
    HealthManager Health;
    Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = maxHealth;

        damageManager = GetComponent<DamageManager>();
        Health = GetComponent<HealthManager>();
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCurrentHealth <= 0) Destroy(gameObject);

        if (CrossPlatformInputManager.GetButtonDown("Attack enemy"))
        {
            //damageManager.Damage(Power, Attack, enemy.Defense);
            enemy.enemyCurrentHealth = Health.remainingHealth(playerCurrentHealth, damageManager.Damage(Power, Attack, enemy.Defense));
            Debug.Log("Enemy takes damage");
        }
    }
}
