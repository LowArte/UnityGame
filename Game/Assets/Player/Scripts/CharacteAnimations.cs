using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteAnimations : MonoBehaviour
{
    public PlayerProperty characterProperty;
    public CharacterMovement characterMovement;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(characterMovement.transform.position, characterMovement.nav.destination) <= 0.1f)
        {
            characterProperty.isRunning = false;
            characterMovement.target = Vector3.zero;
        }
        anim.SetBool("Walk", characterProperty.isRunning);
    }
}
