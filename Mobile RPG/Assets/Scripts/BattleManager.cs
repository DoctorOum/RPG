using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour
{
    //list of all players you command
    public List<GameObject> Players = new List<GameObject>();

    //list of all enemies you will battle throughout scene
    public List<GameObject> Wave1 = new List<GameObject>();
    public List<GameObject> Wave2 = new List<GameObject>();
    public List<GameObject> Wave3 = new List<GameObject>();
    public List<GameObject> BossWave = new List<GameObject>();

    //master list that will hold both players and enemies to determine what order they attack in
    public List<GameObject> WholeCombat = new List<GameObject>();

    //list for the current round, after someone does their action they are thrown out of the list
    public List<GameObject> CurrentRound = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
