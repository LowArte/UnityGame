using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mo : MonoBehaviour
{
    NavMeshAgent nav;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
     void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 5000))
            {
                nav.SetDestination(hit.point);
                nav.Resume();
            }
            if (Vector3.Distance(transform.position,nav.destination)<0.1f)
            {
                nav.Stop();
            }
        }
        
    }
    
    
}