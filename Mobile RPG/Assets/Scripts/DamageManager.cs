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

    public void Damage(float Power, float Attack, float Defense)
    {
        float damage = Power * ((Attack / Defense) - (Attack % Defense));
    }
}
