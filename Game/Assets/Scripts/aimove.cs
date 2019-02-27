using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aimove : MonoBehaviour
{
    NavMeshAgent nav;
    Transform target;
    public float speed = 5f;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        nav.SetDestination(target.position);
        
    }
   

}
