﻿using System.Collections;
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
    public float characterSprintingBost;
    public float baseSpeed;
    public float maxSpeed;
    public float minSpeed;
}
