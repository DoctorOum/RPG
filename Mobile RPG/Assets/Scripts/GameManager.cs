using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas battleSystem;
    public Canvas selectEnemy;
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
}
