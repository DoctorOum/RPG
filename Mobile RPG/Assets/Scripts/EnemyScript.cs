using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int currentHelath;
    public int maxHelath;

    public float Power;
    public float Attack;
    public float Defense;

    // Start is called before the first frame update
    void Start()
    {
        currentHelath = maxHelath;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
