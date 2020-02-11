using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas battleSystem;
    public Canvas selectEnemy;
    public PlayerStateMachine player;
    // Start is called before the first frame update
    void Awake()
    {
        if (selectEnemy.enabled)
        {
            selectEnemy.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void waiting()
    {
        battleSystem.enabled = false;
        selectEnemy.enabled = false;
    }

    public void selectEnemyOn()
    {
        battleSystem.enabled = false;
        selectEnemy.enabled = true;
        
    }

    public void battleSystemOn()
    {
        battleSystem.enabled = true;
        selectEnemy.enabled = false;
    }

    public void goBack()
    {
        selectEnemy.enabled = false;
        battleSystem.enabled = true;
    }
}
