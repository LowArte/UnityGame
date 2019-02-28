using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{

    
    public float dist;
    public PropertyAi pa;
    NavMeshAgent nav;
    
    Transform target;
    
    Animator anim;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }
    public void Momuve()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > pa.radius)
        {
            nav.enabled = false;
            //anim.SetBool("walk",false);

        }
        if (dist < pa.radius & dist > pa.atdist)
        {
            nav.enabled = true;
            nav.SetDestination(target.position);
            //  anim.SetBool("walk", true);


        }
        if (dist < pa.atdist)
        {

            // anim.SetBool("walk", false);
            //  anim.SetBool("attak", true);
            nav.enabled = true;
        }


    }
}
