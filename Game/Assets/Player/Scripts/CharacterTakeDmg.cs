using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterTakeDmg : MonoBehaviour
{
    public PropertyAi pa;
    public PlayerProperty Player;

    // Update is called once per frame
   
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "damage")
            {
                Player.characterHP -= pa.damage;
            }
        }
    
}
