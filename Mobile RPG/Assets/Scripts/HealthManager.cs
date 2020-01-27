using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int remainingHealth(int currentHealth, int damage)
    {
        int health = currentHealth - damage;
        return health;
    }
}
