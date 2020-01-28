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

    public DamageManager damageManager;
    //HealthManager Health;
    Enemy[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = maxHealth;
        //Health = GetComponent<HealthManager>();
        enemy = GameObject.FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCurrentHealth <= 0) Destroy(gameObject);

        if (CrossPlatformInputManager.GetButtonDown("Attack"))
        {
            Debug.Log(enemy.Length);
            int damage = damageManager.Damage(Power, Attack, enemy[0].Defense);
            enemy[0].enemyCurrentHealth = damageManager.remainingHealth(enemy[0].enemyCurrentHealth, damage);
            Debug.Log("Enemy takes damage");
        }
    }
}
