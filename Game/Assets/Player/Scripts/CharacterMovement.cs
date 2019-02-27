using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 target;
    public NavMeshAgent nav;

    public PlayerProperty PlayerProperty;

    public float rotationSpeed = 5f;

    private void Start()
    {

        nav = GetComponent<NavMeshAgent>();
    }
    /// <summary>
    /// Передвигает персонажа
    /// </summary>
    public void PlayerMove()
    {
        SetMove();
        PlayerRotate();
    }
    /// <summary>
    /// Определяет куда пойдет персонаж
    /// </summary>
    private void SetMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit, 50000))
            {
                PlayerProperty.isRunning = true;
                nav.SetDestination(hit.point);
                target = hit.point;
            }
        }
    }
    /// <summary>
    /// Определяет угол поворота для персонажа
    /// </summary>
    private void PlayerRotate()
    {
        if(target != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target - transform.position), rotationSpeed * Time.deltaTime);
        }
    }
}
