﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{    
    public float dist;
    public PropertyAi pa;
    public PropertyAi currentMobAI;
    NavMeshAgent nav;

    Transform target;
    
    Animator anim;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        currentMobAI = new PropertyAi();
    }

    public void Momuve()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > pa.AgrRadius)
        {
            anim.SetTrigger("idle");
        }

        if (dist < pa.AgrRadius)
        {
            
            nav.SetDestination(target.position);
            anim.SetTrigger("run");

        }

        if (dist < pa.atdist)
        {
            
           anim.SetTrigger("attack");

        }


    }
}
