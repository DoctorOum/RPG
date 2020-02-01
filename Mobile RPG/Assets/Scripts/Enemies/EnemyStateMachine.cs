using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseEnemy Enemy;
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

                break;
        }
    }

    void SelectingAttack()
    {

    }
}
