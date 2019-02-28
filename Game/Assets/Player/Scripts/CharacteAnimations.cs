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
    public void Animate()
    {
        anim.SetFloat("WalkSpeed", characterProperty.characterSpeed);
    }
}
