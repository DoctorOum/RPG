﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasePlayer
{
    public string name;
    public float MaxHP;
    public float CurrHP;
    public float Power;
    public float Attack;
    public float Defense;
    public float Accuracy;
    public float CritChance;
    public bool playersTurn = true;


    //counter till they can use their Special
    public float Special;

    //counter till they can use their Ultimate
    public float Ultimate;

    public int TierLvl;



    //Enemy types to be added at a later date
    public enum Type
    {
        Water,
        Fire,
        Light,
        Dark,
        Earth,
        Normal,
        Wind

    }

    public Type EnemyType;
    //

}