using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseEnemy Enemy;

    float randomval = Random.value;

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
        currState = TurnState.WAITING;
        
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

                break;

            case (TurnState.BLOCK):

                break;

            case (TurnState.SPECIAL):

                break;

            case (TurnState.ULTIMATE):

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
        if(Enemy.TierLvl == 1)
        {
            //tier 1 enemies only can attack and defend
            if (randomval <= .5)
            {

                currState = TurnState.ATTACK;
            }
            if (randomval > .5)
            {

                currState = TurnState.BLOCK;
            }
        }

        if (Enemy.TierLvl == 2)
        {
            //tier 2 enemies can attack, defend and Special
            //if enemy energy above half they now have a 20% chance to use their special
            if(Enemy.CurrEnegy >= 50)
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
        if (Enemy.TierLvl == 3)
        {
            //tier 3 enemies only can attack, defend, special and Ultimate
            //if enemy energy above half they now have a 20% chance to use their special
            if (Enemy.CurrEnegy >= 50)
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
                if (randomval <= .35)
                {

                    currState = TurnState.ATTACK;
                }
                if (randomval > .35)
                {

                    currState = TurnState.BLOCK;
                }
                if (randomval <= .15)
                {
                    Enemy.CurrEnegy = Enemy.CurrEnegy - 50;
                    currState = TurnState.SPECIAL;
                }
                if (randomval <= .15)
                {
                    Enemy.CurrEnegy = Enemy.CurrEnegy - 100;
                    currState = TurnState.ULTIMATE;
                }
            }


        }

    }
    //TODO allow enemy to attack which ever player it chooses based on its preferance. ie low health target, high health, top to bottom...
    void Attacking()
    {

    }

    void Defending()
    {
        //buff defense for 1 round
    }

    void SpecialAttack()
    {

    }

    void UltimateAttack()
    {

    }

    void Dead()
    {
        Destroy(this.gameObject);
    }

}
