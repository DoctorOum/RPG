using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour
{
    //list of all players you command
    public List<GameObject> Players = new List<GameObject>();

    public enum PerformAction
    {
        WAIT,
        TAKEACTION,
        PERFORMACTION,

    }

    public PerformAction battlestates;

    public List<HandleTurn> PerformList = new List<HandleTurn>();

    public List<GameObject> HerosInGame = new List<GameObject>();
    public List<GameObject> Heros = new List<GameObject>();
    public List<GameObject> EnemiesInGame = new List<GameObject>();
    public List<GameObject> Wave1 = new List<GameObject>();
    public List<GameObject> Wave2 = new List<GameObject>();
    public List<GameObject> Wave3 = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        battlestates = PerformAction.WAIT;
        HerosInGame.AddRange(Heros);
        EnemiesInGame.AddRange(Wave1);

    }

    // Update is called once per frame
    void Update()
    {
        WaveDefeated();

        switch (battlestates)
        {
            case (PerformAction.WAIT):

                break;
            case (PerformAction.TAKEACTION):

                break;

            case (PerformAction.PERFORMACTION):

                break;
        }
    }

    public void battleStartList()
    {
        HerosInGame.AddRange(Heros);
        EnemiesInGame.AddRange(Wave1);
    }

    public void WaveDefeated()
    {
        if(Wave1.Count == 0 && Wave2.Count > 0)
        {
            EnemiesInGame.AddRange(Wave2);
        }
        if (Wave1.Count == 0 && Wave2.Count == 0)
        {
            EnemiesInGame.AddRange(Wave3);
        }
    }
}
