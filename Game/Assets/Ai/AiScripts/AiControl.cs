using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{

    public AiAnimat setanim;
    public float dist;
    public PropertyAi pa;
    NavMeshAgent nav;
   // public PlayerProperty PlayerProperty;
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
            gameObject.GetComponent<Animator>().SetTrigger("idle");

        }
        if (dist < pa.radius)
        {
            
            nav.SetDestination(target.position);
            gameObject.GetComponent<Animator>().SetTrigger("run");

        }
        if (dist < pa.atdist)
        {
            gameObject.GetComponent<Animator>().SetTrigger("attack");

        }


    }
}
