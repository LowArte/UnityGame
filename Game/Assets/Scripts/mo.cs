using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mo : MonoBehaviour
{
    public float speed;
    Animator anim;
    NavMeshAgent nav;
    
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
     void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {

            anim.SetBool("Walk", true);
            if (Physics.Raycast(ray, out hit, 5000))
            {
                nav.SetDestination(hit.point);
                nav.isStopped=false;   
            }
        }

        if (Vector3.Distance(transform.position, nav.destination) <= 0.1f)
        {
            anim.SetBool("Walk", false);
            nav.isStopped = true; ;
        }
    }
    
    
}