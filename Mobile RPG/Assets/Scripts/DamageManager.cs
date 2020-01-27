using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Damage(int Power, int Attack, int Defense)
    {
        //if player attacking; Attack = player attack, Defense = enemy defense
        int damage = Power * ((Attack / Defense) - (Attack % Defense));
        return damage;
    }
}
