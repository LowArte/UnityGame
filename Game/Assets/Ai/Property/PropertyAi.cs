using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ai/Status")]
public class PropertyAi : ScriptableObject
{
    public bool stop;
   
    public float speed;
    public bool isdead;
    public float hp;
    
    public float AgrRadius;
    public float atdist;
    
}
