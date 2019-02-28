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
}
