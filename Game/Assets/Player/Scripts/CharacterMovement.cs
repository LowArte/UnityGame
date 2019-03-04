using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    private float x;
    private float y;

    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Move()
    {
        x = Input.GetAxis("Vertical");
        y = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y, 0), 0.2f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y - 90, 0), 0.2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y - 180, 0), 0.2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y + 90, 0), 0.2f);
        }
        animator.SetFloat("Vertical", x, 0.1f, Time.deltaTime);
        animator.SetFloat("Horizontal", x, 0.1f, Time.deltaTime);
    }
}
