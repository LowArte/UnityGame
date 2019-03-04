using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterTakeDmg : MonoBehaviour
{
    public PropertyAi pa;
    public PlayerProperty Player;

    public CamerScript maincam;
    public GameObject heroprefab;
    public GameObject current;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
   
        void OnTriggerEnter(Collider other)
        {
        
        if (other.tag == "damage")
            {
                Debug.Log("asdd");
                Player.characterHP -= pa.damage;
            /* maincam.target = heroprefab.transform;
                Destroy(current);*/
            }
        
        }
   





}
