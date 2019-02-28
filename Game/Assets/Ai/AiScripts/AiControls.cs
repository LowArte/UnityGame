using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControls : MonoBehaviour
{
    AiControl move;
    
    void Start()
    {
        move = GetComponent<AiControl>();
    }

   
    void Update()
    {
        move.Momuve();
    }

  
}
