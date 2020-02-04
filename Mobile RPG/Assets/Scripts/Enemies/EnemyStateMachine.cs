using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseEnemy Enemy;

    public DamageManager damageManager;

    public bool blocking;

    float randomval;

    public enum TurnState
    {
        WAITING,
        SELECTING,
        ATTACK,
        BLOCK,
        SPECIAL,
        ULTIMATE,
        DEAD
    }

    public TurnState currState;
    // Start is called before the first frame update
    void Start()
    {
        randomval = Random.value;
        currState = TurnState.WAITING;
        blocking = false;

    }

    // Update is called once per frame
    void Update()
    {
        switch (currState)
        {
            case (TurnState.WAITING):

                break;

            case (TurnState.SELECTING):
                SelectingAttack();
                break;

            case (TurnState.ATTACK):
                Attacking(2.0f);
                break;

            case (TurnState.BLOCK):

                break;

            case (TurnState.SPECIAL):
                Attacking(3.0f);
                break;

            case (TurnState.ULTIMATE):
                Attacking(5.0f);
                break;

            case (TurnState.DEAD):
                Dead();
                break;
        }
        if (Enemy.CurrHP <= 0)
        {
            currState = TurnState.DEAD;
        }
    }
    //TODO make it easier for designers to adjust the value probability the enem selects attack, block, spelial or ultimate
    void SelectingAttack()
    {
        if (blocking)
        {
            Enemy.Defense = Enemy.Defense / 1.5f;
            blocking = false;
        }
        if(Enemy.TierLvl == 1)      //tier 1 enemies only can attack and defend
        {
            
            if (randomval <= .5)
            {

                currState = TurnState.ATTACK;
            }
            if (randomval > .5)
            {

                currState = TurnState.BLOCK;
            }
        }

        if (Enemy.TierLvl == 2)     //tier 2 enemies can attack, defend and Special
        {
            
           
            if(Enemy.CurrEnegy >= 50)       //if enemy energy above half they now have a 20% chance to use their special
            {
                if (randomval <= .2)
                {
                    currState = TurnState.ATTACK;
                }
                if (randomval > .4)
                {
                    currState = TurnState.BLOCK;
                }
                if (randomval <= .4)
                {
                    currState = TurnState.SPECIAL;
                }
            }
            else
            {
                if (randomval <= .5)
                {
                    currState = TurnState.ATTACK;
                }
                if (randomval > .5)
                {
                    currState = TurnState.BLOCK;
                }
            }
            
        }
        if (Enemy.TierLvl == 3)     //tier 3 enemies only can attack, defend, special and Ultimate
        {
            
            
            if (Enemy.CurrEnegy >= 50)      //if enemy energy above half they now have a 20% chance to use their special
            {
                if (randomval <= .4)
                {

                    currState = TurnState.ATTACK;
                }
                if (randomval > .4)
                {

                currState = TurnState.BLOCK;
                }
                if (randomval <= .2)
                {
                    Enemy.CurrEnegy = Enemy.CurrEnegy - 50;
                    currState = TurnState.SPECIAL;
                }
            }
            //if enemy energy at full they have a 20% chance to use their special or ultimate
            if (Enemy.CurrEnegy >= 100)
            {
                if (randomval <= .15)
                {

                    currState = TurnState.ATTACK;
                }
                if (randomval > .15)
                {

                    currState = TurnState.BLOCK;
                }
                if (randomval <= .25)
                {
                    Enemy.CurrEnegy = Enemy.CurrEnegy - 50;
                    currState = TurnState.SPECIAL;
                }
                if (randomval <= .45)
                {
                    Enemy.CurrEnegy = Enemy.CurrEnegy - 100;
                    currState = TurnState.ULTIMATE;
                }
            }


        }

    }

    //TODO allow enemy to attack which ever player it chooses based on its preferance. ie low health target, high health, top to bottom...
    void Attacking(float Power)
    {
        damageManager.Damage(Power, Enemy.Attack, Enemy.Defense);
    }

    void Defending()
    {
        blocking = true;
        Enemy.Defense = Enemy.Defense * 1.5f;        //buff defense for 1 round

    }

    void Dead()
    {
        Destroy(this.gameObject);
    }

}
