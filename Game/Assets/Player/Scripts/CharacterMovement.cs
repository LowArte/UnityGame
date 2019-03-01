using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public string suck;
    public Vector3 target;
    public NavMeshAgent nav;
    public PlayerProperty PlayerProperty;
    public float spid;

    public float rotationSpeed = 5f;
    public float stopDistance = 1.5f;

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
        Sprint();
    }

    private void Sprint()
    {
        if (PlayerProperty.isSprinting)
        {
            PlayerProperty.characterSpeed = Mathf.Lerp(PlayerProperty.characterSpeed, PlayerProperty.maxSpeed, Time.deltaTime);
            if(PlayerProperty.characterSpeed > PlayerProperty.maxSpeed)
            {
                PlayerProperty.characterSpeed = PlayerProperty.maxSpeed;
            }
        }
        else
        {
            PlayerProperty.characterSpeed = Mathf.Lerp(PlayerProperty.characterSpeed, PlayerProperty.baseSpeed, Time.deltaTime);
            if(PlayerProperty.characterSpeed < PlayerProperty.baseSpeed)
            {
                PlayerProperty.characterSpeed = PlayerProperty.baseSpeed;
            }

            if(!PlayerProperty.isRunning)
            {
                PlayerProperty.characterSpeed = 0;
            }

        }
    }
    /// <summary>
    /// Определяет куда пойдет персонаж
    /// </summary>
    private void SetMove()
    {
        nav.speed = PlayerProperty.characterSpeed;
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
        CorrectSpeed();
        if (Vector3.Distance(transform.position, nav.destination) <= 0.25)
        {
            PlayerProperty.isRunning = false;
            PlayerProperty.isSprinting = false;
            target = Vector3.zero;
        }
    }
    /// <summary>
    /// Корректирует скорость перед отсановкой
    /// </summary>
    private void CorrectSpeed()
    {
        if (Vector3.Distance(transform.position, nav.destination) < stopDistance && PlayerProperty.isRunning)
        {
            PlayerProperty.characterSpeed = Mathf.Lerp(PlayerProperty.characterSpeed, 0, 3 * Time.deltaTime);
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
