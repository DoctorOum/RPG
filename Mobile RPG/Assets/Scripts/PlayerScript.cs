using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour
{
    bool choosingEnemy;

    public float Power = 2;
    public int Attack;
    public int Defense;

    public int playerCurrentHealth;
    public int maxHealth;

    public DamageManager damageManager;
    public Enemy[] enemy = new Enemy[3];


    public Canvas battleSystem;
    public Canvas selectEnemy;

    void Awake()
    {
        if (selectEnemy.enabled)
        {
            selectEnemy.enabled = false;
        }
    }


    void Start()
    {
        choosingEnemy = false;
        playerCurrentHealth = maxHealth;
        //enemy = GameObject.FindObjectsOfType<Enemy>();
    }


    void Update()
    {
        if (playerCurrentHealth <= 0) Destroy(gameObject);

        if (CrossPlatformInputManager.GetButtonDown("Attack")) //Attacking, selecting enemy now
        {
            Debug.Log("There are " + enemy.Length + "Enemies!");

            battleSystem.enabled = false;
            selectEnemy.enabled = true;
            choosingEnemy = true;

            Debug.Log("Choosing Enemy");
        }
        if (choosingEnemy)
        {
            if (CrossPlatformInputManager.GetButtonDown("Enemy 1"))
            {
                Damaging(0);
                selectEnemy.enabled = false;
                battleSystem.enabled = true;
                choosingEnemy = false;
                Debug.Log("Enemy takes damage");
                Debug.Log("Enemy's current health" + enemy[0].enemyCurrentHealth);
            } else if (CrossPlatformInputManager.GetButtonDown("Enemy 2"))
            {
                Damaging(1);
                selectEnemy.enabled = false;
                battleSystem.enabled = true;
                choosingEnemy = false;
                Debug.Log("Enemy takes damage");
                Debug.Log("Enemy's current health" + enemy[1].enemyCurrentHealth);
            }else if (CrossPlatformInputManager.GetButtonDown("Enemy 3"))
            {
                Damaging(2);
                selectEnemy.enabled = false;
                battleSystem.enabled = true;
                choosingEnemy = false;
                Debug.Log("Enemy takes damage");
                Debug.Log("Enemy's current health" + enemy[2].enemyCurrentHealth);
            }else if (CrossPlatformInputManager.GetButtonDown("Go Back"))
            {
                selectEnemy.enabled = false;
                battleSystem.enabled = true;
                choosingEnemy = false;
            }
            else { 
            Debug.Log("No longer Choosing enemy");
            }
        }
    }

    public void Damaging(int Enemy)
    {
        int damage = damageManager.Damage(Power, Attack, enemy[Enemy].Defense);
        enemy[Enemy].enemyCurrentHealth = damageManager.remainingHealth(enemy[Enemy].enemyCurrentHealth, damage);
    }
}
