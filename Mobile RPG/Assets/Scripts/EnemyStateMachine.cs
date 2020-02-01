using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseEnemy Enemy;
    public enum TurnState
    {
        WAITING,
        ATTACK,
        SPECIAL,
        ULTIMATE,
        DEAD
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
