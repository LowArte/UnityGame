using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character/Status")]
public class PlayerProperty : ScriptableObject
{
    public bool isDead;
    public bool isUseSkill;
    public bool isRunning;
    public bool isSprinting;

    public float characterSpeed;
<<<<<<< HEAD
    public float characterSprintingBost;
    public float baseSpeed;
    public float maxSpeed;
    public float minSpeed;
=======
    public float characterHP;
    public float characterMP;

    public float damage;
    public float agility;
    public float strength;
    public float intelege;
>>>>>>> 818090f6bbf3b9a38177752c43c3094a61a0154a
}
