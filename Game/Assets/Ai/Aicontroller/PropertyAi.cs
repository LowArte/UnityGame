﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ai/Status")]
public class PropertyAi : ScriptableObject
{
    public bool stop;
    public bool isrun;
    public bool isattak;
    public float speed;
    public bool isdead;
    public float hp;
    
    public float radius;
    public float atdist;
    
}
