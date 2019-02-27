using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    Vector3 target;
    private Animator anim;

    private NavMeshAgent nav;

    public float rotationSpeed = 5f;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    public void PlayerMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("Walk", true);
            if (Physics.Raycast(ray, out RaycastHit hit, 50000))
            {
                nav.SetDestination(hit.point);
                target = hit.point;
            }
        }

        if (Vector3.Distance(transform.position, nav.destination) <= 0.1f)
        {
            anim.SetBool("Walk", false);
            target = Vector3.zero;
        }
        PlayerRotate();
    }

    private void PlayerRotate()
    {
        if(target != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target - transform.position), rotationSpeed * Time.deltaTime);
        }
    }
}
