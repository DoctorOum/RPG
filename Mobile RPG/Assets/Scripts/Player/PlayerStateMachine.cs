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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
