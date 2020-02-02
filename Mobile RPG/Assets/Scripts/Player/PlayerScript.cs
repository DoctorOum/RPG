using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour
{
    bool choosingEnemy;
    bool playersTurn;

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
        playersTurn = true;
        choosingEnemy = false;
        playerCurrentHealth = maxHealth;
        //enemy = GameObject.FindObjectsOfType<Enemy>();
    }


    void Update()
    {
        if (playerCurrentHealth <= 0) Destroy(gameObject);

        if (playersTurn)
        {
            if (CrossPlatformInputManager.GetButtonDown("Attack")) //Attack selected
            {
                chooseEnemy();
            }

            if (choosingEnemy)
            {
                if (CrossPlatformInputManager.GetButtonDown("Enemy 1"))
                {
                    damagingEnemy(0);
                    Debug.Log("Enemy takes damage ");
                    Debug.Log(enemy[0]  + "'s health is " + enemy[0].enemyCurrentHealth);
                }
                else if (CrossPlatformInputManager.GetButtonDown("Enemy 2"))
                {
                    damagingEnemy(1);
                    Debug.Log("Enemy takes damage ");
                    Debug.Log(enemy[0] + "'s health is " + enemy[1].enemyCurrentHealth);
                }
                else if (CrossPlatformInputManager.GetButtonDown("Enemy 3"))
                {
                    damagingEnemy(2); 
                    Debug.Log("Enemy takes damage ");
                    Debug.Log(enemy[0] + "'s health is " + enemy[2].enemyCurrentHealth);
                }
                else if (CrossPlatformInputManager.GetButtonDown("Go Back"))
                {
                    selectEnemy.enabled = false;
                    battleSystem.enabled = true;
                    choosingEnemy = false;
                    Debug.Log("No longer Choosing enemy");
                }
            }
        }

        if (!playersTurn) //enemeies turn
        {
            selectEnemy.enabled = false;
            battleSystem.enabled = false;

            damagingPlayer(); //random enemy attacks

        }
    }

    public void damagingEnemy(int Enemy)
    {
        int damage = damageManager.Damage(Power, Attack, enemy[Enemy].Defense);
        enemy[Enemy].enemyCurrentHealth = damageManager.remainingHealth(enemy[Enemy].enemyCurrentHealth, damage);

        // After damage it switches to Enemy's turn
        selectEnemy.enabled = false;
        battleSystem.enabled = true;
        choosingEnemy = false;
        playersTurn = false;
    }

    public void damagingPlayer()
    {
        int randomEnemy = Random.Range(0, enemy.Length);
        int damage = damageManager.Damage(enemy[randomEnemy].Power, enemy[randomEnemy].Attack, Defense);
        playerCurrentHealth = damageManager.remainingHealth(playerCurrentHealth, damage);

        //end enemies turn
        Debug.Log("You have " + playerCurrentHealth + " health");
        playersTurn = true;
        battleSystem.enabled = true;
    }

    void chooseEnemy()
    {
        battleSystem.enabled = false;
        selectEnemy.enabled = true;
        choosingEnemy = true;

        Debug.Log("Choosing Enemy");
    }
}
