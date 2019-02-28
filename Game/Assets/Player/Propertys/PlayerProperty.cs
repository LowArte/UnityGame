using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character/Status")]
public class PlayerProperty : ScriptableObject
{
    public bool isDead;
    public bool isUseSkill;
    public bool isRunning;

    public float characterSpeed;
    public float characterHP;
    public float characterMP;

    public float damage;
    public float agility;
    public float strength;
    public float intelege;
}
