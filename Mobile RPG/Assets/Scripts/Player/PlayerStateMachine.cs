using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    public BasePlayer player;

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

            break;

            case (Turnstate.SELECTING):

            break;

            case (Turnstate.ATTACK):

                break;

            case (Turnstate.BLOCK):

                break;

            case (Turnstate.SPECIAL):

                break;

            case (Turnstate.ULTIMATE):

                break;

            case (Turnstate.DEAD):

                break;
        }
    }
    


}
