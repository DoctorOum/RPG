using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerStateMachine : MonoBehaviour
{
    public BasePlayer player;
    public BaseEnemy enemy;
    public GameManager gameManager;
    public DamageManager damageManager;
    public BattleManager battleManager;

    public enum Turnstate
    {
        WAITING,
        SELECTING,
        ATTACK,
        BLOCK,
        SPECIAL,
        ULTIMATE,
        DEAD
    }

    public Turnstate currentState;

    // Start is called before the first frame update
    void Start()
    {
        
        currentState = Turnstate.WAITING;
        player.CurrHP = player.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case (Turnstate.WAITING):

               if (player.playersTurn)
                {
                    currentState = Turnstate.SELECTING;
                }
               else
                {
                    gameManager.waiting(); //No UI so enemies can attack
                }
                break;

            case (Turnstate.SELECTING):
                battleSelect(); //Choosing Attack, Special or block
                break;

            case (Turnstate.ATTACK):
                gameManager.selectEnemyOn();
                break;

            case (Turnstate.BLOCK):

                break;

            case (Turnstate.SPECIAL):
                gameManager.selectEnemyOn();
                break;

            case (Turnstate.ULTIMATE):
                gameManager.selectEnemyOn();
                break;


            case (Turnstate.DEAD):

                break;
        }
    }

    void battleSelect()
    {
        if (CrossPlatformInputManager.GetButtonDown("Attack"))
        {
            currentState = Turnstate.ATTACK;
        }

        if (CrossPlatformInputManager.GetButtonDown("Special"))
        {
            currentState = Turnstate.SPECIAL;
        }

        if (CrossPlatformInputManager.GetButtonDown("Block"))
        {
            currentState = Turnstate.BLOCK;
        }
    }

    public void damagingEnemy(int chooseEnemy)
    {
        battleManager.Wave1[chooseEnemy] = gameObject.GetComponent.enemy; // make a way to get the defesnse of the enemy at the certain point in the list
        float damage = damageManager.Damage(player.Power, player.Attack, battleManager.Wave1[0].);
        damageManager.remainingHealth();
    }


}
